// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
open System.Drawing
open System.IO
open System.Net
open System.Windows.Forms

//let form = new System.Windows.Forms.Form(Visible = true, TopMost = true, Text = "Welcome to F#")

/// Writing the same code as above, but doing so dynamically
let form = new Form()
form.Visible <- true
form.TopMost <- true
form.Text <- "Welcome to F#"

let textB = new RichTextBox(Dock = DockStyle.Fill)
form.Controls.Add(textB)

let req = WebRequest.Create("http://fsharp.org")
let resp = req.GetResponse()
let stream = resp.GetResponseStream()
let reader = new StreamReader(stream)
let html = reader.ReadToEnd()

textB.Text <- html

Application.Run(form)