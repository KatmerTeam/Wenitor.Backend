$(function () {
    var dataTable = $('#TargetSourcesTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        ajax: abp.libs.datatables.createAjax(katmer.wenitor.targetSources.getList),
        columnDefs: [
            { data: "name" },
        ]
    }));
});