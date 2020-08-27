// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Path_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MovePath_Info))]
  [KnownType(typeof (ReworkPath_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Path_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_OnDefaultRoute")]
    protected Info _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_IsDefaultPath")]
    protected Info _IsDefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_ReturnToStep")]
    protected Info _ReturnToStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_FromStep")]
    protected Info _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "Path_Info_TxnDetails")]
    protected TxnDetails_Info _TxnDetails;

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

    public Info OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public Info IsDefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefaultPath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsDefaultPath));
      }
    }

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public Info ReturnToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReturnToStep));
      }
    }

    public Info FromStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStep));
      }
    }

    public Info ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStep));
      }
    }

    public new Info IsFrozen
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

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
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

    public TxnDetails_Info TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetails_Info) this.PropertyGet(nameof (TxnDetails));
      }
    }
  }
}
