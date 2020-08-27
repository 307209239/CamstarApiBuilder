// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EmailReminderChanges_Environment))]
  [KnownType(typeof (DispatchDetailChanges_Environment))]
  [KnownType(typeof (DataPointQueryParamChanges_Environment))]
  [KnownType(typeof (StartTimerTaskDtlChanges_Environment))]
  [KnownType(typeof (SampleSizeDetailsChanges_Environment))]
  [KnownType(typeof (UIPreferenceMapChanges_Environment))]
  [KnownType(typeof (SessionValuesChanges_Environment))]
  [KnownType(typeof (ResourceStatusDiagramChgs_Environment))]
  [KnownType(typeof (EventClassSpecMapChanges_Environment))]
  [KnownType(typeof (ProductionProcessDetailChanges_Environment))]
  [KnownType(typeof (PathSelectorChanges_Environment))]
  [KnownType(typeof (QualityProcessingMapChanges_Environment))]
  [KnownType(typeof (TxnMapChanges_Environment))]
  [KnownType(typeof (UserProfileChanges_Environment))]
  [KnownType(typeof (QualityReportConfigChanges_Environment))]
  [KnownType(typeof (WIPMsgDefMgrChanges_Environment))]
  [KnownType(typeof (StartTimerTxnMapChanges_Environment))]
  [KnownType(typeof (CategoryMapChanges_Environment))]
  [KnownType(typeof (EmployeeRoleChanges_Environment))]
  [KnownType(typeof (EndTimerTaskDtlChanges_Environment))]
  [KnownType(typeof (ApprovalSheetMapChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (EndTimerTxnMapChanges_Environment))]
  [KnownType(typeof (NumberingRuleMapChanges_Environment))]
  [KnownType(typeof (SamplingPlanDetailsChanges_Environment))]
  [KnownType(typeof (EmployeeLoginInfoChanges_Environment))]
  [KnownType(typeof (PortalMenuItemChanges_Environment))]
  [KnownType(typeof (CollaboratorEntryChanges_Environment))]
  [KnownType(typeof (ActionsMenuItemChanges_Environment))]
  [KnownType(typeof (CategoryNotificationMapChanges_Environment))]
  [KnownType(typeof (BizRuleParameterChanges_Environment))]
  [KnownType(typeof (DispositionDataChanges_Environment))]
  [KnownType(typeof (UIPortalProfileChanges_Environment))]
  [KnownType(typeof (ApprovalSheetEntryChanges_Environment))]
  [KnownType(typeof (FailureDataChanges_Environment))]
  [KnownType(typeof (ChangeHistoryChanges_Environment))]
  [KnownType(typeof (WIPMsgDetailChanges_Environment))]
  [KnownType(typeof (SwitchingRuleDetailsChanges_Environment))]
  [KnownType(typeof (LabelTxnMapChanges_Environment))]
  [KnownType(typeof (ComputationParamMapChanges_Environment))]
  [KnownType(typeof (DisallowedTxnsChanges_Environment))]
  [KnownType(typeof (ESigReqTxnMapChanges_Environment))]
  [KnownType(typeof (UISourcePageChanges_Environment))]
  [KnownType(typeof (AssignedMaintReqChanges_Environment))]
  [KnownType(typeof (WhereUsedConfigDetailsChanges_Environment))]
  [KnownType(typeof (UITargetLinkChanges_Environment))]
  [KnownType(typeof (BPSpecBizRuleTxnMapChanges_Environment))]
  [KnownType(typeof (NotificationEventChanges_Environment))]
  [KnownType(typeof (UITargetConditionChanges_Environment))]
  [KnownType(typeof (ModelingObjsToExcludeChanges_Environment))]
  [KnownType(typeof (WIPMsgConfigChanges_Environment))]
  [KnownType(typeof (NamedSubentityChanges_Environment))]
  [KnownType(typeof (DelegationTaskChanges_Environment))]
  [KnownType(typeof (WIPMsgKeyChanges_Environment))]
  [KnownType(typeof (HorizontalShiftOptionsChanges_Environment))]
  [KnownType(typeof (ResponseItemChanges_Environment))]
  [KnownType(typeof (LotSizeDetailsChanges_Environment))]
  [KnownType(typeof (ProcessTimerDtlChanges_Environment))]
  [KnownType(typeof (ProcessTimerMapDtlChanges_Environment))]
  [KnownType(typeof (TxnDetailsChanges_Environment))]
  [KnownType(typeof (UIFloatPageLayoutChanges_Environment))]
  [KnownType(typeof (TrainingRecordChanges_Environment))]
  [KnownType(typeof (MenuItemChanges_Environment))]
  [KnownType(typeof (RegulatoryReportMapChanges_Environment))]
  [KnownType(typeof (DictionaryLabelChanges_Environment))]
  [KnownType(typeof (ButtonLabelChanges_Environment))]
  [KnownType(typeof (PermissionDefinitionChanges_Environment))]
  [KnownType(typeof (CalendarShiftChanges_Environment))]
  [KnownType(typeof (CurrentResourceStatusChanges_Environment))]
  [KnownType(typeof (UIFloatPageLocationChanges_Environment))]
  [KnownType(typeof (UIPersonalizationChanges_Environment))]
  [KnownType(typeof (SchedulingDetailChanges_Environment))]
  [KnownType(typeof (QueryStringParameterChanges_Environment))]
  [KnownType(typeof (TrainingPlanDetailChanges_Environment))]
  [Serializable]
  public class SubentityChanges_Environment : BaseObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Environment_DisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    protected Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Environment_ListItemToChange")]
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO.  SubEntityChanges are used as temporary holding places while the parent CDO is undergoing maintenance.", "SubentityChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Environment_Parent")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1048825, false, false, false, null)]
    protected Environment _Parent;
    [Metadata("Sub-Entities are structures that only exist within the context of another CDO. This typically equates to a list-type field within a Modeling CDO.", "Subentity", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Environment_ObjectToChange")]
    protected Environment _ObjectToChange;

    public Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
