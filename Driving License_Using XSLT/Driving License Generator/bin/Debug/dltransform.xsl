<?xml version="1.0" encoding="iso-8859-1"?> 
<xsl:stylesheet version="1.0"  xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns="http://www.w3.org/1999/xhtml">

<xsl:template match="/">

<html>
    <head>
        <link rel="stylesheet" type="text/css" href="style.css"/>
    </head>
	
	<body style="font-family: arial;">
    <div class = "bodyStart">
        <img src="emblem.jpg" class="logo"/>
        <div class = "header">
          <div class="toptext1">THE UNION OF <xsl:value-of select="License/Country"/></div>
          <div class="toptext2"><xsl:value-of select="License/State"/> STATE MOTOR DRIVING LICENCE</div>
          <ul class="liststyle">
            <li>DL No : <span class="bold"><xsl:value-of select="License/LicenseNo"/></span></li>
            <li style="float: left">Valid Till: <span class="bold"><xsl:value-of select="License/ExpiryDate"/></span></li>
          </ul>
          <p class = "issuedate">DOI: <span class="bold"><xsl:value-of select="License/IssueDate"/></span></p>
				</div>
        <img src="center.jpg" class="Centre"/>
      
        <div class="row1">
          <div class="bold">DLD <span class="bold">26-06-2015</span>
          <ul class="liststyle1">
					    <li><span class="bolditalics">FORM 7</span></li>
              <li><span class="bolditalics">RULE 16(2)</span></li>
            </ul>
          </div>
        </div>
      
        <div class= "row2">
			    <img src="Chip.png" class= "chip"/>
				  <ul class="info" style="margin-left: 10px; margin-right: 8px;">
					 <li style="font-size: 10px">AUTHORISATION TO DRIVE FOLLOWING CLASS</li>
					 <li style="font-size: 10px">OF VEHICLES THROUGHOUT <xsl:value-of select="License/Country"/></li>
					 <li>COV  &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160; DOI</li>
					 <li><span class="bold"><xsl:value-of select="License/Vehicle"/>   &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;<xsl:value-of select="License/VehicleDate"/></span></li>
					 <li><br /><br/><br/>DOB &#160;&#160;  :&#160;&#160; <span class="bold"><xsl:value-of select="License/BirthDate"/></span>
          &#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160;&#160; BG &#160; : </li>
				 </ul>
				 <img src="seinfeld.jpeg" class="profilephoto" />
		    </div>
			
		    <div class= "row3">
				  <ul class="liststyle info" style = "margin-left: 30px">
					  <li>Name &#160;&#160;&#160; :<span class="bold"><xsl:value-of select="License/FullName"/></span></li>
					  <li>S/D/W of:<span class="bold"><xsl:value-of select="License/FatherName"/></span></li>
					  <li>Add :<span class="bold"><xsl:value-of select="License/AptName"/></span> <br/>
					  <span class="bold"><xsl:value-of select="License/Street"/></span></li>
					  <li><span class="bold"><xsl:value-of select="License/City"/></span></li>
					  <li>PIN :<span class="bold"><xsl:value-of select="License/PinCode"/></span></li>
					  <li>Signature and ID of</li>
					  <li>Issuing Authority: &#160;&#160;&#160;&#160;&#160; <span class="bold"><xsl:value-of select="License/AuthorityID"/></span></li>
				  </ul>
				  <ul class="sign">
            <li><img src="seinfeld.jpeg" class="photo"/></li>
            <li><img src="signature.jpg" class="signature"/></li>
					  <li>Signature/Thumb</li>
					  <li>Impression of Holder</li>
				  </ul>
        </div>
    </div>
</body>
</html>
</xsl:template>
</xsl:stylesheet>
