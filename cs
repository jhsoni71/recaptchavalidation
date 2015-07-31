
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html>
<head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"></script>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <style>
        /***
Bootstrap Line Tabs by @keenthemes
A component of Metronic Theme - #1 Selling Bootstrap 3 Admin Theme in Themeforest: http://j.mp/metronictheme
Licensed under MIT
***/

        /* Tabs panel */
        .tabbable-panel {
            border: 1px solid #eee;
            padding: 10px;
            min-height:500px;
        }

        /* Default mode */
        .tabbable-line > .nav-tabs {
            border: none;
            margin: 0px;
        }

            .tabbable-line > .nav-tabs > li {
                margin-right: 2px;
            }

                .tabbable-line > .nav-tabs > li > a {
                    border: 0;
                    margin-right: 0;
                    color: #737373;
                }

                    .tabbable-line > .nav-tabs > li > a > i {
                        color: #a6a6a6;
                    }

                .tabbable-line > .nav-tabs > li.open, .tabbable-line > .nav-tabs > li:hover {
                    border-bottom: 4px solid #fbcdcf;
                }

                    .tabbable-line > .nav-tabs > li.open > a, .tabbable-line > .nav-tabs > li:hover > a {
                        border: 0;
                        background: none !important;
                        color: #333333;
                    }

                        .tabbable-line > .nav-tabs > li.open > a > i, .tabbable-line > .nav-tabs > li:hover > a > i {
                            color: #a6a6a6;
                        }

                    .tabbable-line > .nav-tabs > li.open .dropdown-menu, .tabbable-line > .nav-tabs > li:hover .dropdown-menu {
                        margin-top: 0px;
                    }

                .tabbable-line > .nav-tabs > li.active {
                    border-bottom: 4px solid #f3565d;
                    position: relative;
                }

                    .tabbable-line > .nav-tabs > li.active > a {
                        border: 0;
                        color: #333333;
                    }

                        .tabbable-line > .nav-tabs > li.active > a > i {
                            color: #404040;
                        }

        .tabbable-line > .tab-content {
            margin-top: -3px;
            background-color: #fff;
            border: 0;
            border-top: 1px solid #eee;
            padding: 15px 0;
        }

        .portlet .tabbable-line > .tab-content {
            padding-bottom: 0;
        }

        /* Below tabs mode */

        .tabbable-line.tabs-below > .nav-tabs > li {
            border-top: 4px solid transparent;
        }

            .tabbable-line.tabs-below > .nav-tabs > li > a {
                margin-top: 0;
            }

            .tabbable-line.tabs-below > .nav-tabs > li:hover {
                border-bottom: 0;
                border-top: 4px solid #fbcdcf;
            }

            .tabbable-line.tabs-below > .nav-tabs > li.active {
                margin-bottom: -2px;
                border-bottom: 0;
                border-top: 4px solid #f3565d;
            }

        .tabbable-line.tabs-below > .tab-content {
            margin-top: -10px;
            border-top: 0;
            border-bottom: 1px solid #eee;
            padding-bottom: 15px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h3>Home Loan Calculators</h3>
                <div class="tabbable-panel">
                    <div class="tabbable-line">
                        <ul class="nav nav-tabs ">
                            <li class="active">
                                <a href="#tab_default_1" data-toggle="tab">
                                    Loan Eligibility
                                </a>
                            </li>
                            <li>
                                <a href="#tab_default_2" data-toggle="tab">
                                    Tab 2
                                </a>
                            </li>
                            <li>
                                <a href="#tab_default_3" data-toggle="tab">
                                    Tab 3
                                </a>
                            </li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane active" id="tab_default_1">
                                <h3>
                                    How much loan you are eligible for?
                                </h3>
                                <form id="loandata">
                                    <div class="col-sm-6 col-md-6">
                                        <div class="panel panel-default">
                                            <div class="panel-body form-horizontal payment-form">
                                                <div class="form-group">
                                                    <label for="concept" class="col-sm-3 control-label">Loan Required</label>
                                                    <div class="col-sm-9">
                                                        <input type="text" class="form-control" id="principal" name="principal">
                                                        <span class="alert-danger hidden" id="principalMsg">Loan amount should be between 5 lac to 100 cr</span>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label for="description" class="col-sm-3 control-label">Net income per month</label>
                                                    <div class="col-sm-9">
                                                        <input type="text" class="form-control" id="monthlyIncome" name="monthlyIncome">
                                                        <span class="alert-danger hidden" id="monthlyIncomeMsg">Monthy income should be between 10,000 to 100 cr</span>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label for="ellec" class="col-sm-3 control-label">Existing loan commitments</label>
                                                    <div class="col-sm-9">
                                                        <input type="number" class="form-control" id="ellec" name="ellec">
                                                        <span class="alert-danger hidden" id="monthlyIncomeMsg">Monthy loan commitments should be between 10,000 to 100 cr and less than monthly income</span>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label for="ltlec" class="col-sm-3 control-label">Loan Tenure</label>
                                                    <div class="col-sm-9">
                                                        <input type="number" class="form-control" id="years" name="years">
                                                        <span class="alert-danger hidden" id="yearsMsg">Loan tenure year should be between 1 to 50</span>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label for="rlec" class="col-sm-3 control-label">Rate of Interest</label>
                                                    <div class="col-sm-9">
                                                        <input type="number" class="form-control" id="interest" name="interest">
                                                        <span class="alert-danger hidden" id="interestMsg">Rate of interest should be between 1 to 50</span>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <div class="col-sm-12 text-right">
                                                        <input class="btn" type="button" value="Check Eligibility" onclick="calculate();">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-sm-6 col-md-6">
                                        <div class="panel panel-default">
                                            <div class="panel-body form-horizontal payment-form">
                                                <h3 id="elMsg"></h3>
                                            </div>
                                        </div>
                                    </div>
                                </form>
                                
                            </div>
                            <div class="tab-pane" id="tab_default_2">
                                <p>
                                    Howdy, I'm in Tab 2.
                                </p>
                                <p>
                                    Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat. Ut wisi enim ad minim veniam, quis nostrud exerci tation.
                                </p>
                                <p>
                                    <a class="btn btn-warning" href="http://j.mp/metronictheme" target="_blank">
                                        Click for more features...
                                    </a>
                                </p>
                            </div>
                            <div class="tab-pane" id="tab_default_3">
                                <p>
                                    Howdy, I'm in Tab 3.
                                </p>
                                <p>
                                    Duis autem vel eum iriure dolor in hendrerit in vulputate. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat
                                </p>
                                <p>
                                    <a class="btn btn-info" href="http://j.mp/metronictheme" target="_blank">
                                        Learn more...
                                    </a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
<script>
    $('#principal').blur(function () {
        
        if ($('#principal').val() =='') {
            $('#principal').val('1500000');
        }
        if ($('#principal').val() != '' && $('#principal').val().length < 6 && $('#principal').val() < 499999) {
            $('#principalMsg').removeClass('hidden');
        }
        else {
            $('#principalMsg').addClass('hidden');
        }
    });
    $('#interest').blur(function () {
        if ($('#interest').val() == '') {
            $('#interest').val('10');
        }
        if ($('#interest').val() != '' && ($('#interest').val() < 1 || $('#interest').val() > 50)) {
            $('#interestMsg').removeClass('hidden');
        }
        else {
            $('#interestMsg').addClass('hidden');
        }
    });
    $('#years').blur(function () {
        if ($('#years').val() == '') {
            $('#years').val('10');
        }
        if ($('#years').val() != '' && ($('#years').val() < 1 || $('#years').val() > 50)) {
            $('#yearsMsg').removeClass('hidden');
        }
        else {
            $('#yearsMsg').addClass('hidden');
        }
    });
    $('#monthlyIncome').blur(function () {
        if ($('#monthlyIncome').val() == '') {
            $('#monthlyIncome').val('40000');
        }
        if ($('#monthlyIncome').val() != '' && ($('#monthlyIncome').val().length < 5 && $('#monthlyIncome').val() < 10000)) {
            $('#monthlyIncomeMsg').removeClass('hidden');
        }
        else {
            $('#monthlyIncomeMsg').addClass('hidden');
        }
    });
    $('#ellec').blur(function () {
        if ($('#ellec').val() == '') {
            $('#ellec').val('0');
        }
    });
    $(function () {
        $('#principal').val('1500000');
        $('#interest').val('10');
        $('#years').val('10');
        $('#monthlyIncome').val('40000');
        $('#ellec').val('0');
        calculate();
    });

    function calculate() {
        // Get the user's input from the form. Assume it is all valid.
        // Convert interest from a percentage to a decimal, and convert from
        // an annual rate to a monthly rate. Convert payment period in years
        // to the number of monthly payments.
        var principal = $('#principal').val();
        var interest = $('#interest').val() / 100 / 12;
        var payments =  $('#years').val() * 12;

        // Now compute the monthly payment figure, using esoteric math.
        var x = Math.pow(1 + interest, payments);
        var monthly = (principal * x * interest) / (x - 1);

        // Check that the result is a finite number. If so, display the results
        if (!isNaN(monthly) &&
            (monthly != Number.POSITIVE_INFINITY) &&
            (monthly != Number.NEGATIVE_INFINITY)) {

            var payment = round(monthly);
            var total = round(monthly * payments);
            var totalinterest = round((monthly * payments) - principal);

            
            if ((($('#monthlyIncome').val() - $('#ellec').val()) / 2) * payments > total) {
                $('#elMsg').html('You are Eligible for this loan');
            }
            else {
                $('#elMsg').html('You are not Eligible for this loan');
            }
        }
            // Otherwise, the user's input was probably invalid, so don't
            // display anything.
        else {
            document.loandata.payment.value = "";
            document.loandata.total.value = "";
            document.loandata.totalinterest.value = "";
            document.loandata.monthlyIncome.value = "";
        }
    }

    // This simple method rounds a number to two decimal places.
    function round(x) {
        return Math.round(x * 100) / 100;
    }
</script>
