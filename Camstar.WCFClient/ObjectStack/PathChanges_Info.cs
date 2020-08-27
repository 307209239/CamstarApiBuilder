// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MovePathChanges_Info))]
  [KnownType(typeof (ReworkPathChanges_Info))]
  [Serializable]
  public class PathChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_ReturnToStep")]
    protected Info _ReturnToStep;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_FromStep")]
    protected Info _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_TxnDetails")]
    protected TxnDetailsChanges_Info _TxnDetails;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_ToStep")]
    protected Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_IsDefaultPath")]
    protected Info _IsDefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_OnDefaultRoute")]
    protected Info _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Info_Description")]
    protected Info _Description;

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

    public TxnDetailsChanges_Info TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetailsChanges_Info) this.PropertyGet(nameof (TxnDetails));
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

    public new Info ObjectToChange
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
