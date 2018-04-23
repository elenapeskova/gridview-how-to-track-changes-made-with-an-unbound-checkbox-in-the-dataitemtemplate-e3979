@ModelType System.Collections.IEnumerable

<script type="text/javascript">
    var DXHiddenObject = { };

    function OnBeginCallback(s, e) {
        e.customArgs["items"] = $.toJSON(DXHiddenObject);
    }

    function OnCheckedChanged(s, e) {
        if(s.GetChecked())
            DXHiddenObject[s.name] = true;
        else
            delete DXHiddenObject[s.name];
    }
</script>           

@Html.Partial("TypedListDataBindingPartial", Model)