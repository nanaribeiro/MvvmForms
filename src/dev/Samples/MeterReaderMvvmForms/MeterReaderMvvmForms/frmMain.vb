﻿Imports ActiveDevelop.MvvmBaseLib
Imports ActiveDevelop.MvvmBaseLib.Mvvm
Imports MRViewModelLibrary

Public Class frmMain

    Private myMainViewModel As New MainViewModel With
        {.DependencyService = New WinFormsDependencyService}

    Private Async Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim buildings = Await MRViewModelLibrary.BuildingViewModel.GetAllBuildings()
    End Sub

    Private Async Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MvvmManager1.DataContext = myMainViewModel
        myMainViewModel.Buildings = Await MRViewModelLibrary.BuildingViewModel.GetAllBuildings()
    End Sub

    Private Sub NewBuildingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBuildingToolStripMenuItem.Click
        If myMainViewModel IsNot Nothing Then
            If myMainViewModel.NewBuildingCommand.CanExecute(Nothing) Then
                myMainViewModel.NewBuildingCommand.Execute(Nothing)
            End If
        End If
    End Sub
End Class

