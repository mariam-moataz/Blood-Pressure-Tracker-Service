<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="User_functions.Registration" %>

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
                margin :10px;
          
     padding:20px;

        
        }
        .auto-style1{
          
            position:relative;
            left: 227px;
            color: white;
            background-color: black;
            padding: 15px 32px;
            text-align: center;
         
            font-size: 16px;
            top: 10px;
            width: 145px;
        }
        #form{
            width:39%;
            background-color:white;
             margin: auto;
  
             box-shadow: 10px 10px 8px #888888;
             padding: 10px;
            height: 642px;
        }
        body {
             background-image: url("lol.jpg");
        }
        .TextBox1{
        

      float:right;
     

       }
    </style>
</head>
<body ">
   <div class ="container" style ="width:100%">
      
        <form id="form" runat="server">
                <div class ="cell" >
                <asp:TextBox class="TextBox1" runat="server" style ="vertical-align:auto" ID="t1"></asp:TextBox>
               
                <label class="orderName">name 
                    
                    </label>
                </div>
            <div class ="cell" >
                <asp:TextBox class="TextBox1" runat="server" style ="vertical-align:auto" ID="TextBox7"></asp:TextBox>
                <label class="orderName">Id </label>
                </div>
            <div class ="cell" >
                <asp:TextBox class="TextBox1"  runat="server" style ="vertical-align:auto" ID="TextBox1"></asp:TextBox>
                <label class="orderName">password </label>
                </div>
                  <div class ="cell">
                <asp:TextBox class="TextBox1" runat="server" ID="t2"></asp:TextBox>
                <label class="orderName"> Age</label>
                 </div>
                <div class ="cell">
                <asp:TextBox class="TextBox1" runat="server" ID="t3"></asp:TextBox>
                <label class="orderName">Weight </label>
                 </div>
                <div class ="cell" >
                    <asp:TextBox class="TextBox1" runat="server" ID="t4"></asp:TextBox>
                    <label class="orderName">gender </label>
                </div>
                <div  class ="cell">
                <asp:TextBox class="TextBox1" runat="server" ID="t5"></asp:TextBox>
                <label class="orderName"> blood pressure</label>
            </div>
            <asp:Button ID="Button2" runat="server" Text="register" CssClass="auto-style1" OnClick="Button2_Click"/>
       
        </form>
       </div>
    </body>
</html>
