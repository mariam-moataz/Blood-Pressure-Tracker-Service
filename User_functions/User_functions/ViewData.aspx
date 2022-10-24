<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewData.aspx.cs" Inherits="User_functions.ViewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
        .orderName{
    
            font-size: 25px;
         
            font-family: Times, "Times New Roman", serif;
           
       }
        .cell {
                margin :20px;
     padding:20px;
        
        }
        .auto-style1{
          
            position:relative;
            left: 228px;
            color: white;
            background-color: black;
            padding: 15px 32px;
            text-align: center;
         
            font-size: 16px;
            top: 3px;
        }
        #form{
            width:39%;
            background-color:white;
             margin: auto;
  
             box-shadow: 10px 10px 8px #888888;
             padding: 10px;
            height: 632px;
        }
        body {
             background-image: url("lol.jpg");
        }
        .TextBox1{
        
                      font-size: 25px;
                      margin-right:40px;
      float:right;
            width: 4px;
        }
        .auto-style2 {
            float: right;
            width: 4px;
        }
    </style>
</head>
<body ">
   <div class ="container" style ="width:100%">
      
        <form id="form" runat="server">
             <div class ="cell" >
               

                 <asp:label class="TextBox1" runat="server" id="Label0"> </asp:label>
                <label class="orderName">ID </label>
                </div>
                <div class ="cell" >
               

                 <asp:label class="TextBox1" runat="server" id="v_t1"> </asp:label>
                <label class="orderName">name </label>
                </div>
                  <div class ="cell">
                <asp:label class="TextBox1" runat="server" id="v_t2"> </asp:label>
                <label class="orderName"> Age</label>
                 </div>
                <div class ="cell">
                <asp:label class="TextBox1" runat="server" id="v_t3"> </asp:label>
                <label class="orderName">Weight </label>
                 </div>
                <label class="orderName">
                </label>
                <div class ="cell" >
                     <asp:label class="TextBox1" runat="server" id="v_t4"> </asp:label>
                    <label class="orderName">gender&nbsp;&nbsp;&nbsp;&nbsp; </label>
                </div>
                <div  class ="cell">
                 <asp:label class="TextBox1" runat="server" id="v_t5"> </asp:label>
                <label class="orderName"> blood pressure </label>
            </div>
                   <asp:Button ID="v_Button1" runat="server" Text="Back" CssClass="auto-style1" OnClick="v_Button1_Click"/>

        </form>
       </div>
    </body>
</html>
