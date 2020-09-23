jQuery(function ($)
{
    $("#login_form").validate({
        rules: {
            email: {
                required: true,
                email: true,
            },
            password: {
                required: true,
            }
        },

        messages: {
            email: {
                required: "**Lütfen email adresinizi giriniz",
                email:"**Lütfen geçerli bir mail adresi giriniz"
            },
            password:"**Lütfen şifrenizi giriniz"
        }
    })
})