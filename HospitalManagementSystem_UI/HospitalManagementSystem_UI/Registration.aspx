<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="HospitalManagementSystem_UI.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hospital Management System</title>
    <h1>Registration</h1>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:pink;">
            <table>
                
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Patient ID"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPatientID" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Patient Name"></asp:Label></td>
                    <td><asp:TextBox ID="txtPatientName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Issue"></asp:Label></td>
                    <td><asp:TextBox ID="txtIssue" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Referral Doctor"></asp:Label></td>
                    <td><asp:TextBox ID="txtReferralDoctor" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Employee ID"></asp:Label></td>
                    <td><asp:TextBox ID="txtEmpID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="Employee Name"></asp:Label></td>
                    <td><asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label7" runat="server" Text="Patient Status"></asp:Label></td>
                    <td><asp:TextBox ID="txtPatientStatus" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="btnEdit_Click"/>
                        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                        <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                        <asp:Button ID="Button5" runat="server" Text="Reset" OnClick="btnReset_Click"/>
                    </td>
                </tr>
            </table>
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server" />
            <hr />
            <h2>Patient Details</h2>
            <asp:GridView ID="gvPatientInfo" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
