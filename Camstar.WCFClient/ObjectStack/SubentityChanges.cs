// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UserProfileChanges))]
  [KnownType(typeof (UITargetLinkChanges))]
  [KnownType(typeof (UITargetConditionChanges))]
  [KnownType(typeof (NamedSubentityChanges))]
  [KnownType(typeof (HorizontalShiftOptionsChanges))]
  [KnownType(typeof (PermissionDefinitionChanges))]
  [KnownType(typeof (UIFloatPageLayoutChanges))]
  [KnownType(typeof (ButtonLabelChanges))]
  [KnownType(typeof (UIFloatPageLocationChanges))]
  [KnownType(typeof (QueryStringParameterChanges))]
  [KnownType(typeof (ActionsMenuItemChanges))]
  [KnownType(typeof (EmailReminderChanges))]
  [KnownType(typeof (NotificationEventChanges))]
  [KnownType(typeof (ApprovalSheetEntryChanges))]
  [KnownType(typeof (SampleSizeDetailsChanges))]
  [KnownType(typeof (BizRuleParameterChanges))]
  [KnownType(typeof (EndTimerTaskDtlChanges))]
  [KnownType(typeof (CollaboratorEntryChanges))]
  [KnownType(typeof (WIPMsgDefMgrChanges))]
  [KnownType(typeof (ComputationParamMapChanges))]
  [KnownType(typeof (ProcessTimerMapDtlChanges))]
  [KnownType(typeof (ProcessTimerDtlChanges))]
  [KnownType(typeof (WIPMsgKeyChanges))]
  [KnownType(typeof (WIPMsgDetailChanges))]
  [KnownType(typeof (WIPMsgConfigChanges))]
  [KnownType(typeof (DictionaryLabelChanges))]
  [KnownType(typeof (DispatchDetailChanges))]
  [KnownType(typeof (SessionValuesChanges))]
  [KnownType(typeof (ProductionProcessDetailChanges))]
  [KnownType(typeof (EmployeeRoleChanges))]
  [KnownType(typeof (EmployeeLoginInfoChanges))]
  [KnownType(typeof (UIPortalProfileChanges))]
  [KnownType(typeof (LabelTxnMapChanges))]
  [KnownType(typeof (ESigReqTxnMapChanges))]
  [KnownType(typeof (ModelingObjsToExcludeChanges))]
  [KnownType(typeof (LotSizeDetailsChanges))]
  [KnownType(typeof (MenuItemChanges))]
  [KnownType(typeof (CalendarShiftChanges))]
  [KnownType(typeof (SchedulingDetailChanges))]
  [KnownType(typeof (DisallowedTxnsChanges))]
  [KnownType(typeof (UIPreferenceMapChanges))]
  [KnownType(typeof (EventClassSpecMapChanges))]
  [KnownType(typeof (QualityProcessingMapChanges))]
  [KnownType(typeof (QualityReportConfigChanges))]
  [KnownType(typeof (CategoryMapChanges))]
  [KnownType(typeof (ApprovalSheetMapChanges))]
  [KnownType(typeof (NumberingRuleMapChanges))]
  [KnownType(typeof (PortalMenuItemChanges))]
  [KnownType(typeof (CategoryNotificationMapChanges))]
  [KnownType(typeof (UISourcePageChanges))]
  [KnownType(typeof (SamplingPlanDetailsChanges))]
  [KnownType(typeof (FailureDataChanges))]
  [KnownType(typeof (SwitchingRuleDetailsChanges))]
  [KnownType(typeof (AssignedMaintReqChanges))]
  [KnownType(typeof (DelegationTaskChanges))]
  [KnownType(typeof (TrainingRecordChanges))]
  [KnownType(typeof (UIPersonalizationChanges))]
  [KnownType(typeof (RegulatoryReportMapChanges))]
  [KnownType(typeof (CurrentResourceStatusChanges))]
  [KnownType(typeof (WhereUsedConfigDetailsChanges))]
  [KnownType(typeof (TxnMapChanges))]
  [KnownType(typeof (BPSpecBizRuleTxnMapChanges))]
  [KnownType(typeof (DispositionDataChanges))]
  [KnownType(typeof (ResourceStatusDiagramChgs))]
  [KnownType(typeof (ResponseItemChanges))]
  [KnownType(typeof (TrainingPlanDetailChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (EndTimerTxnMapChanges))]
  [KnownType(typeof (StartTimerTxnMapChanges))]
  [KnownType(typeof (TxnDetailsChanges))]
  [KnownType(typeof (ChangeHistoryChanges))]
  [KnownType(typeof (PathSelectorChanges))]
  [KnownType(typeof (DataPointQueryParamChanges))]
  [KnownType(typeof (StartTimerTaskDtlChanges))]
  [Serializable]
  public class SubentityChanges : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_DisplayName")]
    protected Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_ListItemToChange")]
    protected SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_Parent")]
    protected BaseObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "SubentityChanges_ObjectToChange")]
    protected SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is SubentityChanges && object.Equals((object) this._DisplayName, (object) ((SubentityChanges) obj)._DisplayName) && (object.Equals((object) this._ListItemToChange, (object) ((SubentityChanges) obj)._ListItemToChange) && object.Equals((object) this._Parent, (object) ((SubentityChanges) obj)._Parent)) && object.Equals((object) this._ObjectToChange, (object) ((SubentityChanges) obj)._ObjectToChange) && base.Equals(obj);
    }

    public Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public BaseObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Parent));
      }
    }

    public SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
