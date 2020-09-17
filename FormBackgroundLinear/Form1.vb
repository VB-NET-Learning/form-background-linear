﻿Public Class Frm_Bg_Linear

    '/*
    '* WINFORM LOAD
    '*/

    Private Sub Frm_Bg_Linear_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawGradientVertical(Color.FromArgb(61, 61, 61), Color.FromArgb(41, 41, 41))
    End Sub

    '/*
    '*  END - WINFORM LOAD
    '*/

    '/*
    '* DRAUW FUNCTION
    '*/

    Private Sub DrawGradientVertical(ByVal vTopColor As Color, ByVal vBottomColor As Color)
        ' Initial params
        Dim objGraphics As Graphics = Me.CreateGraphics
        Dim objBrush As Drawing2D.LinearGradientBrush
        Dim objRectangle As Rectangle
        ' Change val
        objRectangle = Me.DisplayRectangle
        objBrush = New Drawing2D.LinearGradientBrush(objRectangle, vTopColor, vBottomColor, Drawing2D.LinearGradientMode.Vertical)
        ' Fill valor
        objGraphics.FillRectangle(objBrush, objRectangle)
        ' Dispose objs
        objBrush.Dispose()
        objGraphics.Dispose()
    End Sub

End Class
