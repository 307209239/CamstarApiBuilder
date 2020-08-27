// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgDefMgr_Environment
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
  public class WIPMsgDefMgr_Environment : Subentity_Environment
  {
    [Metadata("This subentity will maintain the data for the esignatures associated with the last update to its parent object.", "ModelingESigHistoryDetail", false, false, true, "ModelingESigHistoryDetail", 1050926, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_ESigHistoryDetails")]
    protected ModelingESigHistoryDetail_Environment _ESigHistoryDetails;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("A WIPMsgLabelKey is used to refer to a WIPMsgDetails Object.  A list of these is specified in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key are filtered based on the label in the current step.", "WIPMsgLabelKey", false, false, true, "WIPMsgLabelKey", 1048887, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_LabelKeys")]
    protected WIPMsgLabelKey_Environment _LabelKeys;
    [Metadata("A WIPMsgKey is used to refer to a WIPMsgDetails Object.  This object is refered to in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key will apply to all steps.", "WIPMsgKey", false, false, true, "WIPMsgKey", 1049498, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_AllKey")]
    protected WIPMsgKey_Environment _AllKey;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [Metadata("A WIPMsgLabelKey is used to refer to a WIPMsgDetails Object.  A list of these is specified in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key are filtered based on the current operation.", "WIPMsgOperationKey", false, false, true, "WIPMsgOperationKey", 1048889, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_OperationKeys")]
    protected WIPMsgOperationKey_Environment _OperationKeys;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_WIPMsgType")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048891, false, false, false, null)]
    protected Environment _WIPMsgType;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1048890, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_WIPMsgEntity")]
    protected Environment _WIPMsgEntity;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgDefMgr_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;

    public ModelingESigHistoryDetail_Environment ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (ModelingESigHistoryDetail_Environment) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public WIPMsgLabelKey_Environment LabelKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelKeys), (object) value);
      }
      get
      {
        return (WIPMsgLabelKey_Environment) this.PropertyGet(nameof (LabelKeys));
      }
    }

    public WIPMsgKey_Environment AllKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllKey), (object) value);
      }
      get
      {
        return (WIPMsgKey_Environment) this.PropertyGet(nameof (AllKey));
      }
    }

    public new Environment DisplayName
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

    public WIPMsgOperationKey_Environment OperationKeys
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationKeys), (object) value);
      }
      get
      {
        return (WIPMsgOperationKey_Environment) this.PropertyGet(nameof (OperationKeys));
      }
    }

    public Environment WIPMsgType
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgType));
      }
    }

    public Environment WIPMsgEntity
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgEntity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgEntity));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }
  }
}
