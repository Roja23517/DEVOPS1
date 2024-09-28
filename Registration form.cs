using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Xml.Linq;

using System;

< !DOCTYPE html >
< html lang = "en" >
< head >
    < meta charset = "UTF-8" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Medhanvesh Registration Form</title>
    <style>
        body {


            font-family: Arial, sans-serif;
background - image: url("roja_img");
background - color: #f4f4f4;
            margin: 0;
padding: 0;
display: flex;
justify - content: center;
align - items: center;
height: 100vh;
        }
        .registration - form {
    background - color: #fff;
            padding: 20px;
    border - radius: 10px;
    box - shadow: 0 0 10px rgba(0, 0, 0, 0.1);
width: 300px;
}
        .registration - form h2 {
            text-align: center;
margin - bottom: 20px;
        }
        .registration - form label {
            font-weight: bold;
display: block;
margin: 10px 0 5px;
        }
        .registration - form input[type = "text"],
        .registration - form input[type = "email"],
        .registration - form input[type = "tel"],
        .registration - form select {
            width: 100 %;
padding: 8px;
margin - bottom: 10px;
border: 1px solid #ccc;
            border-radius: 5px;
        }
        .registration - form button {
            width: 100 %;
padding: 10px;
background - color: #28a745;
            color: white;
border: none;
border - radius: 5px;
cursor: pointer;
        }
        .registration - form button: hover {
    background - color: #218838;
        }
    </ style >
</ head >
< body >

< div class= "registration-form" >
    < h2 > Medhanvesh Event Registration</h2>
    <form action = "submit_registration.php" method= "post" >
        < label for="name">Full Name:</ label >
        < input type = "text" id = "name" name = "name" required >

        < label for= "email" > Email Address:</ label >
        < input type = "email" id = "email" name = "email" required >

        < label for= "phone" > Phone Number:</ label >
        < input type = "tel" id = "phone" name = "phone" required >

        < label for= "event" > Event </ label >
        < select id = "event" name = "event" required >
            < option value = "" > Choose an event</ option >
            < option value = "foodstall" > foodstall </ option >
            < option value = "Gamming" > Gamming </ option >
            < option value = "Data Detox" > Data Detox </ option >
        </ select >

        < button type = "submit" > Register </ button >
    </ form >
</ div >

</ body >
</ html >
