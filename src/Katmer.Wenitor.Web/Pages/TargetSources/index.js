$(function () {
    var dataTable = $('#TargetSourcesTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        ajax: abp.libs.datatables.createAjax(katmer.wenitor.targetSource.getList),
        columnDefs: [
            { data: "name" },
        ]
    }));
});