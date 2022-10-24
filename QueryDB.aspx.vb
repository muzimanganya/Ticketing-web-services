﻿Imports System.Data.SqlClient
Imports System.Data

Partial Class QueryDB
    Inherits System.Web.UI.Page
    Dim clsDataLayer As New Datalayer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Try
        If Page.IsPostBack Then
            Dim pageToQuery As String = Request("ctl00$ctl00$body$content$ddlModules").ToString()
            Dim targetDate As String = Request("ctl00$ctl00$body$content$txtDate").ToString()

            If Not String.IsNullOrEmpty(pageToQuery) AndAlso Not String.IsNullOrEmpty(targetDate) Then
                Dim redString As String = String.Format("{0}?requestDate={1}", pageToQuery, targetDate)
                Response.Redirect(redString)
            Else
                'Bad or Empty Date
            End If

        End If
        'Catch ex As Exception
        '    clsDataLayer.LogException(ex)
        '    Response.Redirect("/CustomError.aspx")
        'End Try

        Page.Title = "Query Database Information"
    End Sub
End Class
