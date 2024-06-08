$(function () {
	$(".btn").click(function () {
		$(".reg_form-signin").toggleClass("reg_form-signin-left");
		$(".reg_form-signup").toggleClass("reg_form-signup-left");
		$(".reg_frame").toggleClass("reg_frame-long");
		$(".reg_signup-inactive").toggleClass("reg_signup-active");
		$(".reg_signin-active").toggleClass("reg_signin-inactive");
		$(".reg_forgot").toggleClass("reg_forgot-left");
		$(this).removeClass("reg_idle").addClass("reg_active");
	});
});

$(function () {
	$(".btn-signup").click(function () {
		$(".reg_nav").toggleClass("reg_nav-up");
		$(".reg_form-signup-left").toggleClass("reg_form-signup-down");
		$(".reg_success").toggleClass("reg_success-left");
		$(".reg_frame").toggleClass("reg_frame-short");
	});
});

$(function () {
	$(".btn-signin").click(function () {
		$(".btn-animate").toggleClass("btn-animate-grow");
		$(".reg_welcome").toggleClass("reg_welcome-left");
		$(".reg_cover-photo").toggleClass("reg_cover-photo-down");
		$(".reg_frame").toggleClass("reg_frame-short");
		$(".reg_profile-photo").toggleClass("reg_profile-photo-down");
		$(".reg_btn-goback").toggleClass("reg_btn-goback-up");
		$(".reg_forgot").toggleClass("reg_forgot-fade");
	});
});