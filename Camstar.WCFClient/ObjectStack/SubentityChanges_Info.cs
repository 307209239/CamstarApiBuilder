// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BizRuleParameterChanges_Info))]
  [KnownType(typeof (EndTimerTxnMapChanges_Info))]
  [KnownType(typeof (ResponseItemChanges_Info))]
  [KnownType(typeof (ActionsMenuItemChanges_Info))]
  [KnownType(typeof (NotificationEventChanges_Info))]
  [KnownType(typeof (ApprovalSheetEntryChanges_Info))]
  [KnownType(typeof (StartTimerTxnMapChanges_Info))]
  [KnownType(typeof (SampleSizeDetailsChanges_Info))]
  [KnownType(typeof (UIPersonalizationChanges_Info))]
  [KnownType(typeof (TxnDetailsChanges_Info))]
  [KnownType(typeof (CollaboratorEntryChanges_Info))]
  [KnownType(typeof (WIPMsgDefMgrChanges_Info))]
  [KnownType(typeof (PathSelectorChanges_Info))]
  [KnownType(typeof (RegulatoryReportMapChanges_Info))]
  [KnownType(typeof (WIPMsgKeyChanges_Info))]
  [KnownType(typeof (DataPointQueryParamChanges_Info))]
  [KnownType(typeof (WIPMsgDetailChanges_Info))]
  [KnownType(typeof (WIPMsgConfigChanges_Info))]
  [KnownType(typeof (ResourceStatusDiagramChgs_Info))]
  [KnownType(typeof (DictionaryLabelChanges_Info))]
  [KnownType(typeof (StartTimerTaskDtlChanges_Info))]
  [KnownType(typeof (DispatchDetailChanges_Info))]
  [KnownType(typeof (SessionValuesChanges_Info))]
  [KnownType(typeof (UserProfileChanges_Info))]
  [KnownType(typeof (EndTimerTaskDtlChanges_Info))]
  [KnownType(typeof (EmployeeRoleChanges_Info))]
  [KnownType(typeof (EmployeeLoginInfoChanges_Info))]
  [KnownType(typeof (WhereUsedConfigDetailsChanges_Info))]
  [KnownType(typeof (UIPortalProfileChanges_Info))]
  [KnownType(typeof (ComputationParamMapChanges_Info))]
  [KnownType(typeof (LabelTxnMapChanges_Info))]
  [KnownType(typeof (ESigReqTxnMapChanges_Info))]
  [KnownType(typeof (ModelingObjsToExcludeChanges_Info))]
  [KnownType(typeof (ProcessTimerMapDtlChanges_Info))]
  [KnownType(typeof (LotSizeDetailsChanges_Info))]
  [KnownType(typeof (MenuItemChanges_Info))]
  [KnownType(typeof (CalendarShiftChanges_Info))]
  [KnownType(typeof (ProcessTimerDtlChanges_Info))]
  [KnownType(typeof (SchedulingDetailChanges_Info))]
  [KnownType(typeof (DisallowedTxnsChanges_Info))]
  [KnownType(typeof (TxnMapChanges_Info))]
  [KnownType(typeof (UIPreferenceMapChanges_Info))]
  [KnownType(typeof (ProductionProcessDetailChanges_Info))]
  [KnownType(typeof (EventClassSpecMapChanges_Info))]
  [KnownType(typeof (QualityProcessingMapChanges_Info))]
  [KnownType(typeof (QualityReportConfigChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CategoryMapChanges_Info))]
  [KnownType(typeof (SamplingPlanDetailsChanges_Info))]
  [KnownType(typeof (ApprovalSheetMapChanges_Info))]
  [KnownType(typeof (NumberingRuleMapChanges_Info))]
  [KnownType(typeof (PortalMenuItemChanges_Info))]
  [KnownType(typeof (CategoryNotificationMapChanges_Info))]
  [KnownType(typeof (DispositionDataChanges_Info))]
  [KnownType(typeof (ChangeHistoryChanges_Info))]
  [KnownType(typeof (FailureDataChanges_Info))]
  [KnownType(typeof (SwitchingRuleDetailsChanges_Info))]
  [KnownType(typeof (BPSpecBizRuleTxnMapChanges_Info))]
  [KnownType(typeof (EmailReminderChanges_Info))]
  [KnownType(typeof (AssignedMaintReqChanges_Info))]
  [KnownType(typeof (UISourcePageChanges_Info))]
  [KnownType(typeof (UITargetLinkChanges_Info))]
  [KnownType(typeof (UITargetConditionChanges_Info))]
  [KnownType(typeof (QueryStringParameterChanges_Info))]
  [KnownType(typeof (NamedSubentityChanges_Info))]
  [KnownType(typeof (HorizontalShiftOptionsChanges_Info))]
  [KnownType(typeof (PermissionDefinitionChanges_Info))]
  [KnownType(typeof (TrainingRecordChanges_Info))]
  [KnownType(typeof (UIFloatPageLayoutChanges_Info))]
  [KnownType(typeof (DelegationTaskChanges_Info))]
  [KnownType(typeof (ButtonLabelChanges_Info))]
  [KnownType(typeof (CurrentResourceStatusChanges_Info))]
  [KnownType(typeof (UIFloatPageLocationChanges_Info))]
  [KnownType(typeof (TrainingPlanDetailChanges_Info))]
  [Serializable]
  public class SubentityChanges_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Info_DisplayName")]
    protected Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Info_ListItemToChange")]
    protected Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Info_Parent")]
    protected Info _Parent;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Info_ObjectToChange")]
    protected Info _ObjectToChange;

    public Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Parent));
      }
    }

    public Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
