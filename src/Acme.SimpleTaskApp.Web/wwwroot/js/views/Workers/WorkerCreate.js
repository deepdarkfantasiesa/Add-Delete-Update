(function ($) {
    $(function () {

        var _$formWorker = $('#WorkerCreationForm');

        _$formWorker.find('input:first').focus();

        _$formWorker.validate();
        console.log("worker. submit");
        $("#WorkerSubmit").click(function (e) {

                console.log("before prevent");

                e.preventDefault();

                console.log("onclick");

                if (!_$formWorker.valid()) {
                    return;
                }

                var input = _$formWorker.serializeFormToObject(); 
                abp.services.app.worker.create(input)
                    .done(function () {
                        console.log("create done");
                        location.href = '/Workers';
                    });
            });
    });
})(jQuery);