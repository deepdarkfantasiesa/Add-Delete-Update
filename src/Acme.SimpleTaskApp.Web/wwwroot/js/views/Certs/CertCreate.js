(function ($) {
    $(function () {

        var _$formWorker = $('#CertCreationForm');

        _$formWorker.find('input:first').focus();

        _$formWorker.validate();
        console.log("cert. submit");
        $("#CertSubmit").click(function (e) {

            console.log("before prevent");

            e.preventDefault();

            console.log("onclick");

            if (!_$formWorker.valid()) {
                return;
            }

            var input = _$formWorker.serializeFormToObject();
            abp.services.app.certificate.create(input)
                .done(function () {
                    console.log("create done");
                    location.href = '/Certs';
                });
        });
    });
})(jQuery);