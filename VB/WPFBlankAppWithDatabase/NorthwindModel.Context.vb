﻿Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity
Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace WPFBlankAppWithDatabase

	Partial Public Class NorthwindEntities
		Inherits DbContext

		Public Sub New()
			MyBase.New("name=NorthwindEntities")
		End Sub

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
			Throw New UnintentionalCodeFirstException()
		End Sub

		Public Overridable Property Categories() As DbSet(Of Category)
		Public Overridable Property CustomerDemographics() As DbSet(Of CustomerDemographic)
		Public Overridable Property Customers() As DbSet(Of Customer)
		Public Overridable Property Employees() As DbSet(Of Employee)
		Public Overridable Property Order_Details() As DbSet(Of Order_Detail)
		Public Overridable Property Orders() As DbSet(Of Order)
		Public Overridable Property Products() As DbSet(Of Product)
		Public Overridable Property Regions() As DbSet(Of Region)
		Public Overridable Property Shippers() As DbSet(Of Shipper)
		Public Overridable Property Suppliers() As DbSet(Of Supplier)
		Public Overridable Property Territories() As DbSet(Of Territory)
	End Class
End Namespace
