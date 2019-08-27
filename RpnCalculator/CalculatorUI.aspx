<%@ Page Title="Another Calculator" Language="C#" MasterPageFile="~/RpnCalculator.Master" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="RpnCalculator.CalculatorUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <h1>RPN Calculator</h1>

    <div>
        <asp:Repeater ID="StackViewer" runat="server" ItemType="System.String">
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="Stack1" runat="server" Text='<%# Item %>' />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <section>
        <asp:Textbox ID="NumberInput" CssClass="input" Placeholder="Enter items here." runat="server" />
        <asp:Button ID="Enter" runat="server" Text="Enter" OnClick="HandleEntry" />

        <fieldset>
            <legend>Math Operations</legend>

            <asp:Button ID="AddButton" runat="server" Text="+" OnClick="HandleAdd" />
            <asp:Button ID="SubtractButton" runat="server" Text="-" OnClick="HandleSub" />
            <asp:Button ID="MultiplyButton" runat="server" Text="*" OnClick="HandleMult" />
            <asp:Button ID="DivideButton" runat="server" Text="/" OnClick="HandleDiv" />
            <asp:Button ID="NegateButton" runat="server" Text="+/-" OnClick="HandleNeg" />
        </fieldset>

        <fieldset>
            <legend>Stack Operations</legend>

            <asp:Button ID="DropButton" runat="server" Text="Drop" OnClick="HandleDrop" />
        </fieldset>
    </section>

</asp:Content>
