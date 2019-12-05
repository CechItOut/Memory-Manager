'Daniel Rossano
Public Class Form1
    'Maximum amount of memory; can be changed, but will be 4096 KB by default
    Dim memSize As Integer = 4096
    'Variable to track the amount of memory currently available, which of course by default is all of it
    Dim availMem As Integer = memSize
    'Integer array to keep track of which processes are currently in memory, as well as where they are
    Dim memory(9) As Integer
    'Integer array to keep track of any holes left behind by previous processes
    Dim holes As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    'Since allocation algorithms decide where the processes go, we will use another array to track which processes are already accounted for
    Dim processes(9) As Integer

    Private Sub addProcess_Click(sender As Object, e As EventArgs) Handles addProcess.Click

        Dim addedProcess As Integer
        'first check that the user entered an acceptable data type for memory: one that is not a string
        On Error GoTo error_handler
        addedProcess = CInt(processSize.Text)

        'next we will check if the user is trying to edit the memory available for a process already in memory
        If processes(selectedProcess.SelectedIndex) <> 0 Then
            processSize.Text = "Process already in memory"
            Exit Sub
        End If

        'now check that the value is small enough to fit in available memory, while still being a positive integer
        If addedProcess > availMem Then
            processSize.Text = "Process too big to fit in memory"
            Exit Sub
        End If
        If addedProcess <= 0 Then
            GoTo error_handler
        End If

        'next check that adding this process won't go over the size limit of the available memory

        Dim totalSpace As Integer = 0
        For index As Integer = 0 To 9
            'first find all of the space taken up by the existing processes
            totalSpace = totalSpace + memory(index)
            'while we are at it, we will also check if the process' size is unique
            'this is a requirement for my project as it is difficult to remove a process from memory if there are other processes of the same size
            If processes(index) = addedProcess Then
                processSize.Text = "Process sizes must be unique; there is already a process of " & addedProcess & " KB in memory"
                Exit Sub
            End If
        Next
        'Now add in the space taken up by the new process and check if the sum is too big to fit in memory
        totalSpace = totalSpace + addedProcess
        If totalSpace > memSize Then
            processSize.Text = "Not enough space in memory"
            memory(selectedProcess.SelectedIndex) = 0
        End If

        'now that the added process has been "screened" we can run the allocation algorithms.
        If selectedAlgorithm.SelectedItem = "First Fit" Then
            For index As Integer = 0 To 9
                'if we have found a hole big enough to fit the process
                If (holes(index) >= addedProcess) Then
                    'if there is no process at the current index,
                    If memory(index) = 0 Then
                        memory(index) = addedProcess
                        holes(index) = holes(index) - addedProcess
                        Exit For
                        'if there IS a process at the current index, then we need to "squeeze it in"
                    Else
                        'start by "shifting over" the nonzero processes
                        For index1 As Integer = 0 To 9
                            If memory(index1) = 0 Then
                                For index2 As Integer = 0 To 9
                                    If memory(index2) <> 0 Then
                                        memory(index1) = memory(index2)
                                        memory(index2) = 0
                                        Exit For
                                    End If
                                Next
                            End If
                        Next
                        'now add in the process
                        memory(index) = addedProcess
                        holes(index) = holes(index) - addedProcess
                        Exit For
                    End If
                    'if there is already space for the process, then add it in
                ElseIf (memory(index) = 0) Then
                    memory(index) = addedProcess
                    Exit For
                End If
            Next
        End If
        'now, remove the space the process takes up from available memory
        availMem = availMem - addedProcess
        ListBox1.Items.Add(addedProcess)

        'the process is in memory, but possibly in a different index than the one the user has selected
        'to prevent the same process from being added multiple times, we make use of an array which accounts for the selected processes
        processes(selectedProcess.SelectedIndex) = addedProcess


        ListBox1.Items.Clear()
        ListBox1.Items.Add("Current contents of memory are:")
        For index1 As Integer = 0 To 9
            If memory(index1) <> 0 Then
                For index2 As Integer = 0 To 9
                    If processes(index2) = memory(index1) Then
                        ListBox1.Items.Add("Process " & index2 + 1 & " with " & memory(index1) & " KB")
                        Exit For
                    End If
                Next
            End If
            If holes(index1) <> 0 Then
                ListBox1.Items.Add("Hole of " & holes(index1) & " KB")
            End If
        Next

        Exit Sub

error_handler:
        processSize.Text = "Only positive integers are accepted"
        memory(selectedProcess.SelectedIndex) = 0
    End Sub

    Private Sub removeProcess_Click(sender As Object, e As EventArgs) Handles removeProcess.Click
        If processes(selectedProcess.SelectedIndex) <> 0 Then
            'first find the process' location in memory 
            'since each process' size is unique, we just search the memory array until we find a process whose size matches that of the selected process
            For index As Integer = 0 To 9
                If memory(index) = processes(selectedProcess.SelectedIndex) Then
                    holes(index) = holes(index) + memory(index)
                    memory(index) = 0
                    processes(selectedProcess.SelectedIndex) = 0

                    Exit For
                End If
            Next

        Else
            Exit Sub
        End If


        'calculate how much memory is now available
        availMem = memSize
        For index As Integer = 0 To 9
            availMem = availMem - memory(index)
        Next




        ListBox1.Items.Clear()
        ListBox1.Items.Add("Current contents of memory are:")
        For index1 As Integer = 0 To 9
            If memory(index1) <> 0 Then
                For index2 As Integer = 0 To 9
                    If processes(index2) = memory(index1) Then
                        ListBox1.Items.Add("Process " & index2 + 1 & " with " & memory(index1) & " KB")
                        Exit For
                    End If
                Next
            End If
            If holes(index1) <> 0 Then
                ListBox1.Items.Add("Hole of " & holes(index1) & " KB")
            End If
        Next
    End Sub

    Private Sub changeSize_Click(sender As Object, e As EventArgs) Handles changeSize.Click
        If maxSize.Text.Trim.Equals("") Then
            memSize = 4096

            availMem = memSize
            'calculate how much memory is available
            For index As Integer = 0 To 9
                availMem = availMem - memory(index)
            Next

        End If
        'If the user enters a string instead of a number, go to the error handler
        On Error GoTo error_handler
        memSize = CInt(maxSize.Text.Trim)
        maxSize.Text = memSize
        If (memSize <= 0) Then
            maxSize.Text = "Only positive integers are accepted"
            memSize = 4096

            availMem = memSize
            'calculate how much memory is available
            For index As Integer = 0 To 9
                availMem = availMem - memory(index)
            Next

        End If


        'check to see if the new memory size can fit the previous processes
        For index As Integer = 0 To 9
            If memory(index) > memSize Then
                memSize = memSize + memory(index)
                maxSize.Text = "Specified size has been changed to fit all existing processes"
            End If
        Next

        'calculate how much memory is available
        availMem = memSize
        For index As Integer = 0 To 9
            availMem = availMem - memory(index)
        Next


        ListBox1.Items.Add("Memory size is now " & memSize)
        Exit Sub
error_handler:
        maxSize.Text = "Only positive integers are accepted"
        memSize = 4096

        availMem = memSize
        'calculate how much memory is available
        For index As Integer = 0 To 9
            availMem = availMem - memory(index)
        Next
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub

    Private Sub compactMemory_Click(sender As Object, e As EventArgs) Handles compactMemory.Click
        For index1 As Integer = 0 To 9
            'fill up any "gaps" in memory
            If memory(index1) = 0 Then
                For index2 As Integer = 0 To 9
                    If memory(index2) <> 0 Then
                        memory(index1) = memory(index2)
                        memory(index2) = 0
                        Exit For
                    End If
                Next
            End If
            'all of the valid processes are now contiguous, so we no longer have any holes
            holes(index1) = 0
        Next
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Current contents of memory are:")
        For index1 As Integer = 0 To 9
            If memory(index1) <> 0 Then
                For index2 As Integer = 0 To 9
                    If processes(index2) = memory(index1) Then
                        ListBox1.Items.Add("Process " & index2 + 1 & " with " & memory(index1) & " KB")
                        Exit For
                    End If
                Next
            End If
            If holes(index1) <> 0 Then
                ListBox1.Items.Add("Hole of " & holes(index1) & " KB")
            End If
        Next
    End Sub
End Class
