﻿using GeeksCoreLibrary.Core.Cms;
using GeeksCoreLibrary.Core.Cms.Attributes;

namespace GeeksCoreLibrary.Components.OrderProcess.Models
{
    public class OrderProcessCmsSettingsModel : CmsSettings
    {
        public OrderProcess.ComponentModes ComponentMode { get; set; } = OrderProcess.ComponentModes.Automatic;
        
        #region Tab DataSource properties

        /// <summary>
        /// The Wiser item ID of the order process that should be retrieved.
        /// </summary>
        [CmsProperty(
            PrettyName = "Order process item ID",
            Description = "The Wiser item ID of the order process that should be retrieved.",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.DataSource,
            GroupName = CmsAttributes.CmsGroupName.Basic,
            DisplayOrder = 10
        )]
        public ulong OrderProcessId { get; set; }

        #endregion

        #region Tab layout properties
        
        /// <summary>
        /// The main template.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template",
            Description = "The main template. You can use the variables '{progress}' (which will be replaced by TemplateProgress) and '{step}' (which will be replaced by TemplateStep for the active step).",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic,PaymentMethods",
            DisplayOrder = 10
        )]
        public string Template { get; set; }
        
        /// <summary>
        /// The template for a step in the order process.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template step",
            Description = @"The template for a step in the order process. You can use the following variables here:
<ul>
    <li><strong>{id}</strong> The ID of the Wiser item with the settings for the step.</li>
    <li><strong>{title}</strong> The title of the Wiser item with the settings for the step.</li>
    <li><strong>{header}</strong> The header of the step, which can be edited by the customer in the Wiser item for the step.</li>
    <li><strong>{groups}</strong> The groups of this step, will be replaced by TemplateGroup for each step.</li>
    <li><strong>{footer}</strong> The footer of the step, which can be edited by the customer in the Wiser item for the step.</li>
    <li><strong>{activeStep}</strong> The number of the active step.</li>
    <li><strong>{confirmButtonText}</strong> The text for the button to go to the next step. This will be retrieved from the translations module from Wiser.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 20
        )]
        public string TemplateStep { get; set; }
        
        /// <summary>
        /// The template for a group of fields in the order process.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template group",
            Description = @"The template for a group of fields in the order process. You can use the following variables here:
<ul>
    <li><strong>{id}</strong> The ID of the Wiser item with the settings for the group.</li>
    <li><strong>{title}</strong> The title of the Wiser item with the settings for the group.</li>
    <li><strong>{header}</strong> The header of the group, which can be edited by the customer in the Wiser item for the group.</li>
    <li><strong>{fields}</strong> The fields of this group, will be replaced by the templates for the different fields.</li>
    <li><strong>{footer}</strong> The footer of the group, which can be edited by the customer in the Wiser item for the group.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 30
        )]
        public string TemplateGroup { get; set; }
        
        /// <summary>
        /// The template for a normal input field in the order process.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template input field",
            Description = @"The template for a normal input field in the order process. You can use the following variables here:
<ul>
    <li><strong>{id}</strong> The ID of the Wiser item with the settings for the field.</li>
    <li><strong>{title}</strong> The title of the Wiser item with the settings for the field.</li>
    <li><strong>{fieldId}</strong> The ID of the field as it's set in the settings for the field. This value should be used in the 'name' and 'id' attributes of the input and the 'for' attribute of the label.</li>
    <li><strong>{label}</strong> The label for this field.</li>
    <li><strong>{inputType}</strong> The input type of this field, this value should be used in the 'type' attribute of the input.</li>
    <li><strong>{placeholder}</strong> The placeholder for the field, should be used in the 'placeholder' attribute of the input.</li>
    <li><strong>{required}</strong> This will be replaced with the 'required' attribute if the field is required, or with an empty string if it isn't.</li>
    <li><strong>{pattern}</strong> The regex validation pattern for the field. This will be replaced with the entire attribute (pattern='the pattern') if there is a pattern, or with an empty string if there isn't.</li>
    <li><strong>{value}</strong> The current value of the field, retrieved from the basket or logged in user, or POST variables.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 40
        )]
        public string TemplateInputField { get; set; }
        
        /// <summary>
        /// The template for a radio button field in the order process.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template radio button field",
            Description = @"The template for a radio button field in the order process. You can use the following variables here:
<ul>
    <li><strong>{id}</strong> The ID of the Wiser item with the settings for the field.</li>
    <li><strong>{title}</strong> The title of the Wiser item with the settings for the field.</li>
    <li><strong>{fieldId}</strong> The ID of the field as it's set in the settings for the field. This value should be used in the 'name' and 'id' attributes of the input and the 'for' attribute of the label.</li>
    <li><strong>{label}</strong> The label for this field.</li>
    <li><strong>{placeholder}</strong> The placeholder for the field, should be used in the 'placeholder' attribute of the input.</li>
    <li><strong>{value}</strong> The current value of the field, retrieved from the basket or logged in user, or POST variables.</li>
    <li><strong>{options}</strong> The options for the radio button.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 50
        )]
        public string TemplateRadioButtonField { get; set; }
        
        /// <summary>
        /// The template for a single option in a radio button field in the order process
        /// </summary>
        [CmsProperty(
            PrettyName = "Template radio button option",
            Description = @"The template for a single option in a radio button field in the order process. You can use the following variables here:
<ul>
    <li><strong>{fieldId}</strong> The ID of the field as it's set in the settings for the field. This value should be used in the 'name' and 'id' attributes of the input and the 'for' attribute of the label.</li>
    <li><strong>{required}</strong> This will be replaced with the 'required' attribute if the field is required, or with an empty string if it isn't.</li>
    <li><strong>{checked}</strong> Whether this option should be checked, retrieved from the basket or logged in user, or POST variables. This will be replaced with the 'checked' attribute if it should, or an empty string if it shouldn't.</li>
    <li><strong>{optionText}</strong> The text for the option that the user should see.</li>
    <li><strong>{optionValue}</strong> The value of the option that should be saved to database.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 55
        )]
        public string TemplateRadioButtonFieldOption { get; set; }
        
        /// <summary>
        /// The template for a select / combobox field in the order process.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template select field",
            Description = @"The template for a select / combobox field in the order process. You can use the following variables here:
<ul>
    <li><strong>{id}</strong> The ID of the Wiser item with the settings for the field.</li>
    <li><strong>{title}</strong> The title of the Wiser item with the settings for the field.</li>
    <li><strong>{fieldId}</strong> The ID of the field as it's set in the settings for the field. This value should be used in the 'name' and 'id' attributes of the input and the 'for' attribute of the label.</li>
    <li><strong>{required}</strong> This will be replaced with the 'required' attribute if the field is required, or with an empty string if it isn't.</li>
    <li><strong>{label}</strong> The label for this field.</li>
    <li><strong>{value}</strong> The current value of the field, retrieved from the basket or logged in user, or POST variables.</li>
    <li><strong>{options}</strong> The options for the radio button.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 60
        )]
        public string TemplateSelectField { get; set; }
        
        /// <summary>
        /// The template for a single option in a select field in the order process
        /// </summary>
        [CmsProperty(
            PrettyName = "Template select option",
            Description = @"The template for a single option in a select field in the order process. You can use the following variables here:
<ul>
    <li><strong>{fieldId}</strong> The ID of the field as it's set in the settings for the field. This value should be used in the 'name' and 'id' attributes of the input and the 'for' attribute of the label.</li>
    <li><strong>{required}</strong> This will be replaced with the 'required' attribute if the field is required, or with an empty string if it isn't.</li>
    <li><strong>{selected}</strong> Whether this option should be selected, retrieved from the basket or logged in user, or POST variables. This will be replaced with the 'selected' attribute if it should, or an empty string if it shouldn't.</li>
    <li><strong>{optionText}</strong> The text for the option that the user should see.</li>
    <li><strong>{optionValue}</strong> The value of the option that should be saved to database.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 65
        )]
        public string TemplateSelectFieldOption { get; set; }
        
        /// <summary>
        /// The template for a checkbox field in the order process.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template checkbox field",
            Description = @"The template for a checkbox field in the order process. You can use the following variables here:
<ul>
    <li><strong>{id}</strong> The ID of the Wiser item with the settings for the field.</li>
    <li><strong>{title}</strong> The title of the Wiser item with the settings for the field.</li>
    <li><strong>{fieldId}</strong> The ID of the field as it's set in the settings for the field. This value should be used in the 'name' and 'id' attributes of the input and the 'for' attribute of the label.</li>
    <li><strong>{label}</strong> The label for this field.</li>
    <li><strong>{required}</strong> This will be replaced with the 'required' attribute if the field is required, or with an empty string if it isn't.</li>
    <li><strong>{checked}</strong> Whether this option should be checked, retrieved from the basket or logged in user, or POST variables. This will be replaced with the 'checked' attribute if it should, or an empty string if it shouldn't.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 70
        )]
        public string TemplateCheckboxField { get; set; }
        
        /// <summary>
        /// The template for showing the progress of the user in a multi step order process.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template progress",
            Description = "The template for showing the progress of the user in a multi step order process. The variable '{steps}' can be used here to render the steps on that location.",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 80
        )]
        public string TemplateProgress { get; set; }
        
        /// <summary>
        /// The template for a single step for 'TemplateProgress'.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template progress step",
            Description = @"The template for a single step for 'TemplateProgress'. You can use the following variables here:
<ul>
    <li><strong>{number}</strong> The number of the step. This is not the active step, but a different number for each step in order (1,2,3 etc).</li>
    <li><strong>{activeStep}</strong> The number of the step that is currently active.</li>
    <li><strong>{active}</strong> This will be replaced by the value 'active' if the current step is the active step, or an empty string if it isn't. This can be used to add the 'active' CSS class the the element of the active step.</li>
    <li><strong>{name}</strong> The name of the step.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic",
            DisplayOrder = 80
        )]
        public string TemplateProgressStep { get; set; }
        
        /// <summary>
        /// The template for a single payment method.
        /// </summary>
        [CmsProperty(
            PrettyName = "Template payment method",
            Description = @"The template for a single payment method. You can use the following variables here:
<ul>
    <li><strong>{id}</strong> The ID of the payment method.</li>
    <li><strong>{title}</strong> This name of the payment method.</li>
    <li><strong>{logo}</strong> The URL to the logo for the payment method.</li>
</ul>",
            DeveloperRemarks = "",
            TabName = CmsAttributes.CmsTabName.Layout,
            GroupName = CmsAttributes.CmsGroupName.Templates,
            TextEditorType = CmsAttributes.CmsTextEditorType.HtmlEditor,
            ComponentMode = "Automatic,PaymentMethods",
            DisplayOrder = 90
        )]
        public string TemplatePaymentMethod { get; set; }

        #endregion
    }
}