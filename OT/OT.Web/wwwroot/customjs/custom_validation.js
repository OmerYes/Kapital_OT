jQuery(function ($)
{
    $("#login_form").validate({
        rules: {
            Email: {
                required: true,
                email: true,
            },
            Password: {
                required: true,
            }
        },

        messages: {
            Email: {
                required: "**Lütfen email adresinizi giriniz",
                email:"**Lütfen geçerli bir mail adresi giriniz"
            },
            Password:"**Lütfen şifrenizi giriniz"
        }
    })
})