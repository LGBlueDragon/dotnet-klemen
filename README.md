<!DOCTYPE html>
<html>
	<head>
		<title><% TITLE %></title> 
		<link href="http://locogaming.b1.jcink.com/uploads/locogaming/images/lgfavicon.png" type="image/jpg" rel="icon"/>
		<meta http-equiv="Content-Type" content="text/html;charset=utf-8"/>
		<% GENERATOR %> 
		<% CSS %> 
		<% JAVASCRIPT %>
			<script type='text/javascript'>
				//Alpha plus Global Variables
				// Do not edit or remove. You may add though.
				new_msg ='<!-- |new_msg| -->';
				use_pm = '<!-- |g_use_pm| -->';
				username ='<!-- |name| -->';
				userid ='<!-- |id| -->';
				msg_tot ='<!-- |msg_total| -->';
				g_id = '<!-- |g_id| -->';
				g_is_mod = '<!-- |g_is_supmod| -->';
				g_admin = '<!-- |g_access_cp| -->';
				act = '<!-- |input_act| -->';
				auth_key = '<!-- |auth_key| -->';
				version = '211';
				no_photo = "<{NO_PHOTO}>";
			</script>
			<!-- Do not touch these scripts either -->
			<script type='text/javascript' src='http://gunskins.b1.jcink.com/uploads/gunskins/mods/apv2.js'></script>
			<script type='text/javascript' src='http://gunskins.b1.jcink.com/uploads/gunskins/mods/popup.js'></script>
			<script type='text/javascript' src='http://gunskins.b1.jcink.com/uploads/gunskins/mods/dropdown.js'></script>
	</head>
	<body>
		<div id='gmessage'><span></span></div>
		<div class='fullWrap'>
			<div id='header'>
				<div id='userbar'>
					<ul id='modbar' class='modbar' style='display:none;'>
						<li id='modcp'><a href="index.php?act=modcp">Moderator CP</a></li>
						<li id='modcp'><a href='index.php?act=modcp&CODE=reported'>Reports<span class='alert' id='modcp-num'></span></a></li>
						<li id='modcp'><a href='index.php?act=modcp&CODE=members'>Edit Members</a></li>
						<li id='admincp'><a href="admin.php" target="_blank">Administration CP</a></li>
					</ul>
					<ul id='member' class='bar'>
						<li class='dropmenu'><a id='menu_user' class='click'><!-- |name| --> <{DROP_ARROW}></a>
							<ul class='drop' id='menu_content_user'>
								<div class='drop-row'>
									<a href='index.php?act=UserCP&CODE=24'><div id='insert-avatar'></div></a>
								</div>
								<div class='qlinks'>
								<li><a href='index.php?showuser=<!-- |id| -->'><img src="http://i103.photobucket.com/albums/m130/Gunblaza/fams/user_suit.png"> View profile page</a></li>
								<li><a href='index.php?act=UserCP'><img src="http://i103.photobucket.com/albums/m130/Gunblaza/fams/user_edit.png"> Account settings</a></li>
								<li><a href="javascript:window.open('index.php?showuser=<!-- |id| -->&CODE=friends','Friends','width=620,height=460,resizable=yes,scrollbars=yes');void(0);"><img src="http://i103.photobucket.com/albums/m130/Gunblaza/fams/group_edit.png"> My friends</a></li>
								<li><a href="index.php?act=Search&CODE=getnew"><img src="http://i103.photobucket.com/albums/m130/Gunblaza/fams/page_find.png"> New post</a></li>
								</div>
							</ul>
						</li>
						<li class='dropmenu' id='messenger'><a id='menu_messenger' class='click'>Messenger <{DROP_ARROW}><span class='alert'><!-- |new_msg| --></span></a>
							<ul class='drop' id='menu_content_messenger'>
								<div class='drop-title'><span class='right desc'><a href='index.php?act=Msg&CODE=01'>View all (<!-- |msg_total| -->)</a></span><span id='newmsg'>Messages</span></div>
								<div id='pmshere'><div class='menurow center' style='display:none;' id='nomsgs'>You don't have any messages</div></div>
								<div class='pformstrip center'><a href='#' class='popup click' popupId='messPopup' id='messPop'>Send a new message</a></div>
							</ul>
						</li>
						<li><a href="index.php?act=Login&CODE=03&key=<!-- |auth_key| -->">Log Out</a></li>
					</ul>
					<ul id='guest' class='bar'>
						<li><a href='#' class='popup click' id='loginPop' popupId='loginPopup'>Log In</a></li>
						<li><a href="index.php?act=Reg&CODE=00">Register New Account</a></li>
						<li><a href='index.php?act=Reg&CODE=reval'>Resend Email Validation</a></li>
					</ul>
				</div>
				<div id='logo'>
					<a href='index.php'><{LOGO}></a>
					<div id='searchbar'>
					<form action="index.php?act=Search&CODE=01" method="post">
						<input type="hidden" name="forums" value="all"/>
						<input class="search-input" type="text" name="keywords" value="Search forums" onfocus="this.value=''">
						<input class="search-button" type="submit" value="Search">
					</form>
					</div>
				</div>
			</div>
			<div id="menu"><!-- This is the navigation bar. Please note it can be custom but automatic -->
				<ul id="menu_list">
					<li><a href="index.php" class='default'>Forums</a></li>
				</ul>
			</div>
  
			<div id='<!-- |input_act| -->' class='code-<!-- |input_CODE| -->'>
				<div id='innerWrap' class="wrap">
					<div class='board-ads'><% BOARD HEADER %></div>
					<% NAVIGATION %>
					<% PM %>
					<% BOARD %>
					<div class='tableborder' width='100%'>
					<div class='maintitle' width='100%'>Forum Marker Legend</div>
					<table width='100%'>
					<tr align='center'><td width='12%' class='row2'><{C_ON}></td><td width='12%' class='row2'><{C_OFF}></td><td width='12%' class='row2'><{C_ON_CAT}></td><td width='12%' class='row2'><{C_OFF_CAT}></td><td width='12%' class='row2'><{C_ON_RES}></td><td width='12%' class='row2'><{C_OFF_RES}></td><td width='12%' class='row2'><{C_LOCKED}></td><td width='14%' class='row2'><{BR_REDIRECT}></td></tr>
					<tr align='center'><td class='row2'>New Posts</td><td class='row2'>No New Posts</td><td class='row2'>Sub-forum <br> (New Posts)<br></td><td class='row2'>Sub-forum <br> (No New Posts)</td><td class='row2'>New Locked Posts</td><td class='row2'>No New Locked Posts</td><td class='row2'>Read Only Forum</td><td class='row2'>Redirect Elsewhere</td></tr><tr><td colspan='8' class='darkrow2'> </td></tr></table></div><br /><br />
					<% AFFS %>
					<table cellspacing="0" id="gfooter">
						<tr>
							<td width="45%"><% SKIN_SELECTOR %></td>
							<td width="10%" align="center"><a href="/m/index.php/"><b>Mobile Version</b></a></td>
							<td width="45%" align="right">Last Visit: <!-- |last_visit| --> </td>
						</tr>
					</table>
					<br>
					<div class='copy'><% COPYRIGHT %></div>
				</div>
			</div>
		</div>
       <div class='copy'><a href='http://forum.jcink.com/index.php?showuser=737'><img src='http://i103.photobucket.com/albums/m130/Gunblaza/APlus/alphaplus2_copy.png'></a></div>
	
		<!-- Extras -->
			<div id='loginPopup' class='popupBox'>
				<div class='popupBox-background'></div>
				<div class='popupBox-content'>
					<div class='titlemedium'>
						<span class='right'>
							<a class='closePopup closePopup-img click'><{POPUP_CLOSE}></a>
						</span>
						Login
					</div>
					<form style='display:inline' action="index.php?act=Login&CODE=01&CookieDate=1" method="post">
					<div class='row2' style='padding:6px;'>
						<div class='login-row'>
							<div class='login-col'>
								<div  class='login-title'>Username<a href='index.php?act=Login' class='desc italic'>Use advanced login.</a></div>
								<div>
									<input type="text" class="forminput username" name="UserName" onfocus="this.value=''" value="Username" placeholder="Username">
								</div>
								<div class='login-keep'>
									<input type="checkbox" class="login-check" value="1" name="CookieDate"> Keep me logged in.
								</div>
							</div>
							<div class='login-col'>
								<div class='login-title'>Password<a href='index.php?act=Reg&CODE=10' class='desc italic'>Forgot your password?</a></div>
								<div>
									<input type='password' class='forminput password' name='PassWord' onfocus="this.value=''" value='******' placeholder="******">
								</div>
								<div class='login-anon'>
									<input type="checkbox" class="login-check" value="1" name="Privacy">Check to login anonymously.
								</div>
							</div>
						</div>
					</div>
						<div class='titlemedium center'>
							<input type='submit' value='Log In'>
						</div>
					</form>
				</div>
			</div>
   
			<div id='messPopup' class='popupBox'>
				<div class='popupBox-background'></div>
				<div class='popupBox-content'>
					<div class='titlemedium'>
						<span class='right'>
							<a class='closePopup closePopup-img click'><{POPUP_CLOSE}></a>
						</span>
						Send a New Message - <a href='index.php?act=Msg&CODE=04'>More options</a>
					</div>
					<div class='row2' style='padding:6px;'>
				<form id='qpmForm' name='qpm'>
							<input type='hidden' name='MODE'  value='01'>
							<input type='hidden' name='OID'  value=''>
							<input type='hidden' name='auth_key' value='<!-- |auth_key| -->'>
							<dl class='qpm-design'>
								<dt>Send To:</dt>
								<dd><input type="text" class="forminput" name="entered_name"><div class='desc'>The name must be exactly as it's shown across the board.</div></dd>
								<dt>Subject:</dt>
								<dd><input type='text' name='msg_title' maxlength='40' class='forminput'></dd>
								<dt>Message:</dt>
								<dd><textarea name='Post' class='forminput'></textarea></dd>
							</dl>
					</div>
					<div class='titlemedium align-right'>
						<input type='submit' name='submit' id='qpmButton' value='Send'> <input type='button' class='closePopup cancel' value='Cancel'>
					</div>
				</form>
				</div>
			</div>
 
			<div id='overlay'></div>

			<script type='text/javascript' src='http://gunskins.b1.jcink.com/uploads/gunskins/mods/ap_tedit.js'></script>
			<script type='text/javascript'>
				//--- User CP menu
				var ucp = document.getElementById('ucpmenu');
				ucp.innerHTML = ucp.innerHTML.replace(/(-)|(')|(&nbsp;)|(·)/g, function(r){ return r = ''; });
			</script>
	</body>
</html>

