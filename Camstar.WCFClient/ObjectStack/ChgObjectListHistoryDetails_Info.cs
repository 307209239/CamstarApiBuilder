// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectListHistoryDetails_Info
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
  public class ChgObjectListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_NewDisplayValue")]
    protected new Info _NewDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_NewObjects")]
    protected NewObject_Info _NewObjects;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_OldObjects")]
    protected OldObject_Info _OldObjects;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_OldDisplayValue")]
    protected new Info _OldDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_FieldName")]
    protected new Info _FieldName;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_FieldID")]
    protected new Info _FieldID;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectListHistoryDetails_Info_HistoryId")]
    protected new Info _HistoryId;

    public new Info NewDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDisplayValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewDisplayValue));
      }
    }

    public NewObject_Info NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (NewObject_Info) this.PropertyGet(nameof (NewObjects));
      }
    }

    public OldObject_Info OldObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldObjects), (object) value);
      }
      get
      {
        return (OldObject_Info) this.PropertyGet(nameof (OldObjects));
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

    public new Info OldDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDisplayValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldDisplayValue));
      }
    }

    public new Info FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldName));
      }
    }

    public new Info FieldID
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldID));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
