// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDefMgr_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class WIPMsgDefMgr_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_ESigHistoryDetails")]
    protected ModelingESigHistoryDetail_Info _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_LabelKeys")]
    protected WIPMsgLabelKey_Info _LabelKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_AllKey")]
    protected WIPMsgKey_Info _AllKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_OperationKeys")]
    protected WIPMsgOperationKey_Info _OperationKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_WIPMsgType")]
    protected Info _WIPMsgType;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_WIPMsgEntity")]
    protected Info _WIPMsgEntity;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Info_Description")]
    protected Info _Description;

    public ModelingESigHistoryDetail_Info ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (ModelingESigHistoryDetail_Info) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public WIPMsgLabelKey_Info LabelKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeys), (object) value);
      }
      get
      {
        return (WIPMsgLabelKey_Info) this.PropertyGet(nameof (LabelKeys));
      }
    }

    public WIPMsgKey_Info AllKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllKey), (object) value);
      }
      get
      {
        return (WIPMsgKey_Info) this.PropertyGet(nameof (AllKey));
      }
    }

    public new Info DisplayName
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

    public WIPMsgOperationKey_Info OperationKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeys), (object) value);
      }
      get
      {
        return (WIPMsgOperationKey_Info) this.PropertyGet(nameof (OperationKeys));
      }
    }

    public Info WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgType));
      }
    }

    public Info WIPMsgEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgEntity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgEntity));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
