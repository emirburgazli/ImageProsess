<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadImage.aspx.cs" Inherits="asp_ImageProsess.UploadImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:FileUpload  runat="server" ID="fileUpload"/>
        <br />
        <br />
        <asp:Button runat="server" ID="btn_save" Text="SAVE" OnClick="btn_save_Click" />
    </div>
    </form>
</body>
</html>
