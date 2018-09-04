
<title>Kendo UI Snippet</title>

<link rel="stylesheet" href="http://cdn.kendostatic.com/2014.3.1119/styles/kendo.common.min.css">
<link rel="stylesheet" href="http://cdn.kendostatic.com/2014.3.1119/styles/kendo.rtl.min.css">
<link rel="stylesheet" href="http://cdn.kendostatic.com/2014.3.1119/styles/kendo.default.min.css">
<link rel="stylesheet" href="http://cdn.kendostatic.com/2014.3.1119/styles/kendo.dataviz.min.css">
<link rel="stylesheet" href="http://cdn.kendostatic.com/2014.3.1119/styles/kendo.dataviz.default.min.css">
<link rel="stylesheet" href="http://cdn.kendostatic.com/2014.3.1119/styles/kendo.mobile.all.min.css">

<script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
<script src="http://cdn.kendostatic.com/2014.3.1119/js/kendo.all.min.js"></script>
</head>
<body>
  
<div id="grid"></div>
<script>
$("#grid").kendoGrid({
    columns: [
      { field: "name", footerTemplate: "Silvan Bla" },
      { field: "age",
          footerTemplate: " #: sum #"
      },
      {field:'Location',
          footerTemplate:"#:sum#"
      },
    ],
    dataSource: {
        data: [
          { name: "Jane Doe", age: kendo.toString(12345678, "##,#"),Location:88  },
          { name: "John Doe", age: 3333,Location:88 },
          { name: "John Doe", age: 2223,Location:898  },
          {name:'junaid mahmood',age:797,Location:88 }
        ],
        aggregate: [
            { field: "age", aggregate: "sum" }, //kendo.toString(sum, "##,#")
            {field:"Location",aggregate:"sum"}
        ]
    }
});
</script>

    
    
    
    
    
        