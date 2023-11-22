
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url:'/admin/product/getall'},
    
       "columns": [
           { data: 'title', "width": "15%" }, 
           { data: 'siteAge', "width": "15%" }, 
           { data: 'industry', "width": "15%" },
           { data: 'location', "width": "15%" },
           { data: 'monthlyNetProfit', "width": "15%" },
           { data: 'category.name', "width": "15%" }
           
           
    ]
    });
}

   