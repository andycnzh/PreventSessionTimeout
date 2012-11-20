<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PreventSessionTimeout.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>This page reference this web page:http://www.codeproject.com/Articles/9607/Prevent-Session-Timeout-in-ASP-NET . </p>
            <p>This code will cause the client to request within 30 seconds of the session timeout the page Reconnect.aspx.</p>
        </div>
    </form>
</body>
</html>
