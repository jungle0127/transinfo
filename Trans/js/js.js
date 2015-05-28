// JavaScript Document
/*------------------------返回顶部-------------------------------------------*/
function backToTop(){
    $("#back-to-top").hide();
//当滚动条的位置处于距顶部100像素以下时，跳转链接出现，否则消失
    $(function () {
        $(window).scroll(function () {
            if ($(window).scrollTop() > 100) {
                $("#back-to-top").fadeIn(150);
            }
            else {
                $("#back-to-top").fadeOut(150);
            }
        });
//当点击跳转链接后，回到页面顶部位置
        $("#back-to-top").click(function () {
            $('body,html').animate({scrollTop: 0}, 100);
            return false;
        });
    });
}
/*---------------------控制嵌入的页面高度使得自适应-----------------*/
function frameHeight(){
       var frameWin = document.getElementById("frameInfoDetail");
       var frameBox = document.getElementById("frameBox");
       var newHeight;
       if (frameWin.Document){
              newHeight = frameWin.Document.body.scrollHeight + 20 + "px";
       }else{
              newHeight = frameWin.contentDocument.body.scrollHeight+ 20 + "px";
       }
       frameWin.style.height = newHeight;
       frameBox.style.height = newHeight;
}
/*-------------------------点击退出按钮转到开始页面--------------------------*/
function toIndex(elemid){
	$(elemid).click(function(){
		window.location='../index.html';
	})
}
/*--------------------------------管理界面----------------------
$(function(){
	//setMenuHeight
	$('.menu').height($(window).height()-51-27-26);
	$('.sidebar').height($(window).height()-51-27-26);
	$('.page').height($(window).height()-51-27-26);
	$('.page iframe').width($(window).width()-15-168);
	
	//menu on and off
	$('.btn').click(function(){
		$('.menu').toggle();
		
		if($(".menu").is(":hidden")){
			$('.page iframe').width($(window).width()-15+5);
			}else{
			$('.page iframe').width($(window).width()-15-168);
				}
		});
		
	//
	$('.subMenu a[href="#"]').click(function(){
		$(this).next('ul').toggle();
		return false;
		});
})-------------*/