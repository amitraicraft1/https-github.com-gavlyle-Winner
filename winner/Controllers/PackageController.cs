using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using winner.Db;
using winner.Models;
using Winner;

namespace winner.Controllers
{
    public class PackageController : Controller
    {
        // GET: Package
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DcEnquiry()
        { winnerEntities db = new winnerEntities();
        var resultssingleact = db.DCPPACKSINGLEACTINGs.ToList();
        var resultsdoubleact = db.DCPPACKSINGLEACTINGs.ToList();
        var resultspt = db.DCPPACKSINGLEACTINGs.ToList();

        var Opration = db.DCPPACKOPERATIONs.ToList();
        var MOTORSIZE = db.DCPPACKMOTOR_SIZEs.ToList();
        var VOLTAGE = db.DCPPACKVOLTAGEs.ToList();
        var FLOWRATE = db.DCPPACKFLOWRATEs.ToList();
        var PRESSURESETTING = db.DCPPACKPRESSURESETTINGs.ToList();
        var TYPEOFSYSTEMTOOPERATE = db.DCPPACK_SYSTEMs.ToList();
        var RESERVOIR = db.DCPPACKRESERVOIRSIZEs.ToList();
        var POSITIONOFMOTOR = db.DCPPACKMOTORPOSITIONs.ToList();
        var PENDENT = db.DCPPACKPENDENTs.ToList();

        ViewBag.singleact = resultssingleact;
        ViewBag.doubleact = resultsdoubleact;
        ViewBag.pt= resultspt;

        ViewBag.Opration = Opration;
        ViewBag.MOTORSIZE = MOTORSIZE;
        ViewBag.VOLTAGE = VOLTAGE;
        ViewBag.FLOWRATE = FLOWRATE;
        ViewBag.PRESSURESETTING = PRESSURESETTING;
        ViewBag.TYPEOFSYSTEMTOOPERATE = TYPEOFSYSTEMTOOPERATE;
        ViewBag.RESERVOIR = RESERVOIR;
        ViewBag.POSITIONOFMOTOR = POSITIONOFMOTOR;
        ViewBag.PENDENT = PENDENT;

            return View();
        }
        [HttpPost]
        public ActionResult DcEnquiry(DcEnquiryModel model)
        {
            winnerEntities db = new winnerEntities();
            var resultssingleact = db.DCPPACKSINGLEACTINGs.ToList();
            var resultsdoubleact = db.DCPPACKSINGLEACTINGs.ToList();
            var resultspt = db.DCPPACKSINGLEACTINGs.ToList();


            var Opration1 = db.DCPPACKOPERATIONs.ToList();
            var MOTORSIZE1 = db.DCPPACKMOTOR_SIZEs.ToList();
            var VOLTAGE1 = db.DCPPACKVOLTAGEs.ToList();
            var FLOWRATE1 = db.DCPPACKFLOWRATEs.ToList();
            var PRESSURESETTING1 = db.DCPPACKPRESSURESETTINGs.ToList();
            var TYPEOFSYSTEMTOOPERATE1 = db.DCPPACK_SYSTEMs.ToList();
            var RESERVOIR1 = db.DCPPACKRESERVOIRSIZEs.ToList();
            var POSITIONOFMOTOR1 = db.DCPPACKMOTORPOSITIONs.ToList();
            var PENDENT1 = db.DCPPACKPENDENTs.ToList();

            ViewBag.singleact = resultssingleact;
            ViewBag.doubleact = resultsdoubleact;
            ViewBag.pt = resultspt;

            ViewBag.Opration = Opration1;
            ViewBag.MOTORSIZE = MOTORSIZE1;
            ViewBag.VOLTAGE = VOLTAGE1;
            ViewBag.FLOWRATE = FLOWRATE1;
            ViewBag.PRESSURESETTING = PRESSURESETTING1;
            ViewBag.TYPEOFSYSTEMTOOPERATE = TYPEOFSYSTEMTOOPERATE1;
            ViewBag.RESERVOIR = RESERVOIR1;
            ViewBag.POSITIONOFMOTOR = POSITIONOFMOTOR1;
            ViewBag.PENDENT = PENDENT1;
            if (ModelState.IsValid)
            {
              

                SendMail mail = new SendMail();
                List<string> str = new List<string>();
                str.Add(model.Email);
                System.Text.StringBuilder str1 = new System.Text.StringBuilder();

                str1.Append("<style type='text/css'>" +

    "@media screen and (max-width: 600px) {" +
    "table[class='container'] {" +
    "  width: 95% !important;" +
    "}" +
    "}" +

    "#outlook a {padding:0;}" +

    "body{width:100% !important; -webkit-text-size-adjust:100%; -ms-text-size-adjust:100%;  padding:0;}" +
    ".ExternalClass {width:100%;}" +
    ".ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div {line-height: 100%;}" +
    "#backgroundTable { padding:0; width:100% !important; line-height: 100% !important;}" +
    "img {outline:none; text-decoration:none; -ms-interpolation-mode: bicubic;}" +
    "a img {border:none;}" +
    ".image_fix {display:block;}" +
    "p {}" +
    "h1, h2, h3, h4, h5, h6 {color: #ff725e !important;}" +

    "h1 a, h2 a, h3 a, h4 a, h5 a, h6 a {color: blue !important;}" +

    "h1 a:active, h2 a:active,  h3 a:active, h4 a:active, h5 a:active, h6 a:active {" +
    "	color: red !important;" +
     "}" +

    "h1 a:visited, h2 a:visited,  h3 a:visited, h4 a:visited, h5 a:visited, h6 a:visited {" +
        "color: purple !important;" +
    "}" +

    "table td {border-collapse: collapse;}" +

    "table { border-collapse:collapse;   }" +

    "a {color: #000;}" +

    "@media only screen and (max-device-width: 480px) {" +

        "a[href^='tel'], a[href^='sms'] {" +
                    "text-decoration: none;" +
                    "color: black; /* or whatever your want */" +
                    "pointer-events: none;" +
                    "cursor: default;" +
                "}" +

        ".mobile_link a[href^='tel'], .mobile_link a[href^='sms'] {" +
                    "text-decoration: default;" +
                    "color: orange !important; /* or whatever your want */" +
                    "pointer-events: auto;" +
                    "cursor: default;" +
                "}" +
    "}" +


    "@media only screen and (min-device-width: 768px) and (max-device-width: 1024px) {" +
        "a[href^='tel'], a[href^='sms'] {" +
                    "text-decoration: none;" +
                    "color: blue; /* or whatever your want */" +
                    "pointer-events: none;" +
                    "cursor: default;" +
                "}" +

        ".mobile_link a[href^='tel'], .mobile_link a[href^='sms'] {" +
                    "text-decoration: default;" +
                    "color: orange !important;" +
                    "pointer-events: auto;" +
                    "cursor: default;" +
                "}" +
    "}" +

    "@media only screen and (-webkit-min-device-pixel-ratio: 2) {" +
        "/* Put your iPhone 4g styles in here */" +
    "}" +

    "@media only screen and (-webkit-device-pixel-ratio:.75){" +
        "/* Put CSS for low density (ldpi) Android layouts in here */" +
    "}" +
    "@media only screen and (-webkit-device-pixel-ratio:1){" +
        "/* Put CSS for medium density (mdpi) Android layouts in here */" +
    "}" +
    "@media only screen and (-webkit-device-pixel-ratio:1.5){" +
        "/* Put CSS for high density (hdpi) Android layouts in here */" +
    "}" +
    "/* end Android targeting */" +
    "h2{" +
        "color:#181818;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:22px;" +
        "line-height: 22px;" +
        "font-weight: normal;" +
    "}" +
    "a.link1{" +

    "}" +
    "a.link2{" +
        "color:#fff;" +
        "text-decoration:none;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:16px;" +
        "color:#fff;border-radius:4px;" +
    "}" +
    "p{" +
        "color:#555;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:16px;" +
        "line-height:160%;" +
    "}" +
    "</style>");
                str1.Append("<script type='colorScheme' class='swatch active'>" +
    "{" +
    "'name':'Default'," +
    "'bgBody':'ffffff'," +
    "'link':'fff'," +
    "'color':'555555'," +
    "'bgItem':'ffffff'," +
    "'title':'181818'" +
    "}" +
    "</script>");
                str1.Append("<table cellpadding='0' width='100%' cellspacing='0' border='0' id='backgroundTable' class='bgBody'>" +
    "<tr>" +
    "<td>" +
    "<table cellpadding='0' width='620' class='container' align='center' cellspacing='0' border='0'>" +
    "<tr>" +
    "<td>" +
    "<!-- Tables are the most common way to format your email consistently. Set your table widths inside cells and in most cases reset cellpadding, cellspacing, and border to zero. Use nested tables as a way to space effectively in your message. -->" +


    "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
       "<tr>" +
           "<td class='movableContentContainer bgItem'>" +


               "<div class='movableContent'>" +
                   "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
                       "<tr>" +
                           "<td width='100%' colspan='3' align='center' style='padding-bottom:10px;padding-top:25px;'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='center' >" +
                                       "<h2 style='color: #ff725e !important;'>DC Power Pack Enquiry</h2>" +
                                   "</div>" +
                               "</div>" +
                           "</td>" +
                       "</tr>" +
                       "<tr>" +
                           "<td width='100'>&nbsp;</td>" +
                           "<td width='400' align='center'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='left' >" +

                                   "<p> Opration" + model.Opration + "</p>" +
                                   "<p> MOTOR SIZE" + model.MotorSize + "</p>" +
                                   "<p> VOLTAGE" + model.VOLTAGE + "</p>" +
                                   "<p> FLOW RATE" + model.FLOWRATE + "</p>" +
                                   "<p> PRESSURE SETTING" + model.PRESSURESETTING + "</p>" +
                                   "<p> TYPE OF SYSTEM TO OPERATE" + model.TYPEOFSYSTEM + "</p>" +
                                   "<p> RESERVOIR SIZE" + model.RESERVOIRSIZE + "</p>" +
                                   "<p> POSITION OF MOTOR/PUMP" + model.POSITIONOFMOTOR + "</p>" +
                                   "<p> PENDENT" + model.PENDENT + "</p>" +
                                   "<p> Email " + model.Email + "</p>" +

                                   "<p>" + model.COMMENTS + "</p>" +

                                       "<p >");

                str1.Append("Thank you for your Submitting your details of DC Power Pack,we have got your enquiry</p>");
                str1.Append("</div>" +
                               "</div>" +
                           "</td>" +
                           "<td width='100'>&nbsp;</td>" +
                       "</tr>" +
                   "</table>" +

               "</div>" +


               "<div class='movableContent'>" +
                   "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
                       "<tr>" +
                           "<td width='100%' colspan='2' style='padding-top:65px;'>" +
                               "<hr style='height:1px;border:none;color:#333;background-color:#ddd;' />" +
                           "</td>" +
                       "</tr>" +
                       "<tr>" +
                           "<td width='60%' height='70' valign='middle' style='padding-bottom:20px;'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='left' >" +
                                       "<span style='font-size:13px;color:#181818;font-family:Helvetica, Arial, sans-serif;line-height:200%;'><a href='http://winner.itsoftserve.com/'>Winner</a></span>" +
                                       "<br/>" +

                                   "</div>" +
                               "</div>" +
                           "</td>" +
                           "</tr>" +
                               "</table>" +
                           "</td>" +
                       "</tr>" +
                   "</table>" +
               "</div>" +


           "</td>" +
       "</tr>" +
    "</table>" +




    "</td></tr></table>" +

    "</td>" +
    "</tr>" +
    "</table>");
            }
            return View();
        }
        public ActionResult AcEnquiry()
        {
            winnerEntities db = new winnerEntities();
            var resultssingleact = db.ACPPACKSINGLEACTINGs.ToList();
            var resultsdoubleact = db.ACPPACKSINGLEACTINGs.ToList();
            var resultspt = db.ACPPACKSINGLEACTINGs.ToList();

            var Opration = db.ACPPACKOPERATIONs.ToList();
            var MOTORSIZE = db.ACPPACKMOTORSIZEs.ToList();
            var VOLTAGE = db.ACPPACKVOLTAGEs.ToList();
            var DUTYCYCLE = db.ACPPACKDUTYCYCLEs.ToList();
            var FLOWRATE = db.ACPPACKFLOWRATEs.ToList();
            var PRESSURESETTING = db.ACPPACKPRESSURESETTINGs.ToList();
            var TYPEOFSYSTEMTOOPERATE = db.DCPPACK_SYSTEMs.ToList();
            var RESERVOIR = db.ACPPACKRESERVOIRSIZEs.ToList();
            var POSITIONOFMOTOR = db.ACPPACKPOSITIONOFMOTORs.ToList();
            var PENDENT = db.ACPPACKPENDENTs.ToList();

            ViewBag.singleact = resultssingleact;
            ViewBag.doubleact = resultsdoubleact;
            ViewBag.pt = resultspt;

            ViewBag.Opration = Opration;
            ViewBag.MOTORSIZE = MOTORSIZE;
            ViewBag.VOLTAGE = VOLTAGE;
            ViewBag.DUTYCYCLE = DUTYCYCLE;
            ViewBag.FLOWRATE = FLOWRATE;
            ViewBag.PRESSURESETTING = PRESSURESETTING;
            ViewBag.TYPEOFSYSTEMTOOPERATE = TYPEOFSYSTEMTOOPERATE;
            ViewBag.RESERVOIR = RESERVOIR;
            ViewBag.POSITIONOFMOTOR = POSITIONOFMOTOR;
            ViewBag.PENDENT = PENDENT;

            return View();
        }

        [HttpPost]
        public ActionResult AcEnquiry(AcEnquiryModel model)
        {
            winnerEntities db = new winnerEntities();
            var resultssingleact = db.ACPPACKSINGLEACTINGs.ToList();
            var resultsdoubleact = db.ACPPACKSINGLEACTINGs.ToList();
            var resultspt = db.ACPPACKSINGLEACTINGs.ToList();

            var Opration1 = db.ACPPACKOPERATIONs.ToList();
            var MOTORSIZE1 = db.ACPPACKMOTORSIZEs.ToList();
            var VOLTAGE1 = db.ACPPACKVOLTAGEs.ToList();
            var DUTYCYCLE1 = db.ACPPACKDUTYCYCLEs.ToList();
            var FLOWRATE1 = db.ACPPACKFLOWRATEs.ToList();
            var PRESSURESETTING1 = db.ACPPACKPRESSURESETTINGs.ToList();
            var TYPEOFSYSTEMTOOPERATE1 = db.DCPPACK_SYSTEMs.ToList();
            var RESERVOIR1 = db.ACPPACKRESERVOIRSIZEs.ToList();
            var POSITIONOFMOTOR1 = db.ACPPACKPOSITIONOFMOTORs.ToList();
            var PENDENT1 = db.ACPPACKPENDENTs.ToList();

            ViewBag.singleact = resultssingleact;
            ViewBag.doubleact = resultsdoubleact;
            ViewBag.pt = resultspt;

            ViewBag.Opration = Opration1;
            ViewBag.MOTORSIZE = MOTORSIZE1;
            ViewBag.VOLTAGE = VOLTAGE1;
            ViewBag.DUTYCYCLE = DUTYCYCLE1;
            ViewBag.FLOWRATE = FLOWRATE1;
            ViewBag.PRESSURESETTING = PRESSURESETTING1;
            ViewBag.TYPEOFSYSTEMTOOPERATE = TYPEOFSYSTEMTOOPERATE1;
            ViewBag.RESERVOIR = RESERVOIR1;
            ViewBag.POSITIONOFMOTOR = POSITIONOFMOTOR1;
            ViewBag.PENDENT = PENDENT1;
            if (ModelState.IsValid)
            {
             
               
                SendMail mail = new SendMail();
                List<string> str = new List<string>();
                str.Add(model.Email);
                System.Text.StringBuilder str1 = new System.Text.StringBuilder();

                str1.Append("<style type='text/css'>" +

    "@media screen and (max-width: 600px) {" +
    "table[class='container'] {" +
    "  width: 95% !important;" +
    "}" +
    "}" +

    "#outlook a {padding:0;}" +

    "body{width:100% !important; -webkit-text-size-adjust:100%; -ms-text-size-adjust:100%;  padding:0;}" +
    ".ExternalClass {width:100%;}" +
    ".ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div {line-height: 100%;}" +
    "#backgroundTable { padding:0; width:100% !important; line-height: 100% !important;}" +
    "img {outline:none; text-decoration:none; -ms-interpolation-mode: bicubic;}" +
    "a img {border:none;}" +
    ".image_fix {display:block;}" +
    "p {}" +
    "h1, h2, h3, h4, h5, h6 {color: #ff725e !important;}" +

    "h1 a, h2 a, h3 a, h4 a, h5 a, h6 a {color: blue !important;}" +

    "h1 a:active, h2 a:active,  h3 a:active, h4 a:active, h5 a:active, h6 a:active {" +
    "	color: red !important;" +
     "}" +

    "h1 a:visited, h2 a:visited,  h3 a:visited, h4 a:visited, h5 a:visited, h6 a:visited {" +
        "color: purple !important;" +
    "}" +

    "table td {border-collapse: collapse;}" +

    "table { border-collapse:collapse;   }" +

    "a {color: #000;}" +

    "@media only screen and (max-device-width: 480px) {" +

        "a[href^='tel'], a[href^='sms'] {" +
                    "text-decoration: none;" +
                    "color: black; /* or whatever your want */" +
                    "pointer-events: none;" +
                    "cursor: default;" +
                "}" +

        ".mobile_link a[href^='tel'], .mobile_link a[href^='sms'] {" +
                    "text-decoration: default;" +
                    "color: orange !important; /* or whatever your want */" +
                    "pointer-events: auto;" +
                    "cursor: default;" +
                "}" +
    "}" +


    "@media only screen and (min-device-width: 768px) and (max-device-width: 1024px) {" +
        "a[href^='tel'], a[href^='sms'] {" +
                    "text-decoration: none;" +
                    "color: blue; /* or whatever your want */" +
                    "pointer-events: none;" +
                    "cursor: default;" +
                "}" +

        ".mobile_link a[href^='tel'], .mobile_link a[href^='sms'] {" +
                    "text-decoration: default;" +
                    "color: orange !important;" +
                    "pointer-events: auto;" +
                    "cursor: default;" +
                "}" +
    "}" +

    "@media only screen and (-webkit-min-device-pixel-ratio: 2) {" +
        "/* Put your iPhone 4g styles in here */" +
    "}" +

    "@media only screen and (-webkit-device-pixel-ratio:.75){" +
        "/* Put CSS for low density (ldpi) Android layouts in here */" +
    "}" +
    "@media only screen and (-webkit-device-pixel-ratio:1){" +
        "/* Put CSS for medium density (mdpi) Android layouts in here */" +
    "}" +
    "@media only screen and (-webkit-device-pixel-ratio:1.5){" +
        "/* Put CSS for high density (hdpi) Android layouts in here */" +
    "}" +
    "/* end Android targeting */" +
    "h2{" +
        "color:#181818;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:22px;" +
        "line-height: 22px;" +
        "font-weight: normal;" +
    "}" +
    "a.link1{" +

    "}" +
    "a.link2{" +
        "color:#fff;" +
        "text-decoration:none;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:16px;" +
        "color:#fff;border-radius:4px;" +
    "}" +
    "p{" +
        "color:#555;" +
        "font-family:Helvetica, Arial, sans-serif;" +
        "font-size:16px;" +
        "line-height:160%;" +
    "}" +
    "</style>");
                str1.Append("<script type='colorScheme' class='swatch active'>" +
    "{" +
    "'name':'Default'," +
    "'bgBody':'ffffff'," +
    "'link':'fff'," +
    "'color':'555555'," +
    "'bgItem':'ffffff'," +
    "'title':'181818'" +
    "}" +
    "</script>");
                str1.Append("<table cellpadding='0' width='100%' cellspacing='0' border='0' id='backgroundTable' class='bgBody'>" +
    "<tr>" +
    "<td>" +
    "<table cellpadding='0' width='620' class='container' align='center' cellspacing='0' border='0'>" +
    "<tr>" +
    "<td>" +
    "<!-- Tables are the most common way to format your email consistently. Set your table widths inside cells and in most cases reset cellpadding, cellspacing, and border to zero. Use nested tables as a way to space effectively in your message. -->" +


    "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
       "<tr>" +
           "<td class='movableContentContainer bgItem'>" +


               "<div class='movableContent'>" +
                   "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
                       "<tr>" +
                           "<td width='100%' colspan='3' align='center' style='padding-bottom:10px;padding-top:25px;'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='center' >" +
                                       "<h2 style='color: #ff725e !important;'>AC Power Pack Enquiry</h2>" +
                                   "</div>" +
                               "</div>" +
                           "</td>" +
                       "</tr>" +
                       "<tr>" +
                           "<td width='100'>&nbsp;</td>" +
                           "<td width='400' align='center'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='left' >" +

                                   "<p> Opration" + model.Opration + "</p>" +
                                   "<p> MOTOR SIZE" + model.MotorSize + "</p>" +
                                   "<p> VOLTAGE" + model.VOLTAGE + "</p>" +
                                   "<p> FLOW RATE" + model.FLOWRATE + "</p>" +
                                   "<p> PRESSURE SETTING" + model.PRESSURESETTING + "</p>" +
                                   "<p> TYPE OF SYSTEM TO OPERATE" + model.TYPEOFSYSTEM + "</p>" +
                                   "<p> RESERVOIR SIZE" + model.RESERVOIRSIZE + "</p>" +
                                   "<p> POSITION OF MOTOR/PUMP" + model.POSITIONOFMOTOR + "</p>" +
                                   "<p> PENDENT" + model.PENDENT + "</p>" +
                                   "<p> Email " + model.Email + "</p>" +

                                   "<p>" + model.COMMENTS + "</p>" +

                                       "<p >");

                str1.Append("Thank you for your Submitting your details of AC Power Pack,we have got your enquiry</p>");
                str1.Append("</div>" +
                               "</div>" +
                           "</td>" +
                           "<td width='100'>&nbsp;</td>" +
                       "</tr>" +
                   "</table>" +

               "</div>" +


               "<div class='movableContent'>" +
                   "<table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'>" +
                       "<tr>" +
                           "<td width='100%' colspan='2' style='padding-top:65px;'>" +
                               "<hr style='height:1px;border:none;color:#333;background-color:#ddd;' />" +
                           "</td>" +
                       "</tr>" +
                       "<tr>" +
                           "<td width='60%' height='70' valign='middle' style='padding-bottom:20px;'>" +
                               "<div class='contentEditableContainer contentTextEditable'>" +
                                   "<div class='contentEditable' align='left' >" +
                                       "<span style='font-size:13px;color:#181818;font-family:Helvetica, Arial, sans-serif;line-height:200%;'><a href='http://winner.itsoftserve.com/'>Winner</a></span>" +
                                       "<br/>" +

                                   "</div>" +
                               "</div>" +
                           "</td>" +
                           "</tr>" +
                               "</table>" +
                           "</td>" +
                       "</tr>" +
                   "</table>" +
               "</div>" +


           "</td>" +
       "</tr>" +
    "</table>" +




    "</td></tr></table>" +

    "</td>" +
    "</tr>" +
    "</table>");
            }
            return View();
        }
    }
}