// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PathChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MovePathChanges))]
  [KnownType(typeof (ReworkPathChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class PathChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_ReturnToStep")]
    protected NamedSubentityRef _ReturnToStep;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_FromStep")]
    protected NamedSubentityRef _FromStep;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_TxnDetails")]
    protected TxnDetailsChanges _TxnDetails;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_ToStep")]
    protected NamedSubentityRef _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_IsDefaultPath")]
    protected Primitive<bool> _IsDefaultPath;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_OnDefaultRoute")]
    protected Primitive<bool> _OnDefaultRoute;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PathChanges_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is PathChanges && object.Equals((object) this._ReturnToStep, (object) ((PathChanges) obj)._ReturnToStep) && (object.Equals((object) this._FromStep, (object) ((PathChanges) obj)._FromStep) && object.Equals((object) this._TxnDetails, (object) ((PathChanges) obj)._TxnDetails)) && (object.Equals((object) this._ToStep, (object) ((PathChanges) obj)._ToStep) && object.Equals((object) this._IsDefaultPath, (object) ((PathChanges) obj)._IsDefaultPath) && (object.Equals((object) this._OnDefaultRoute, (object) ((PathChanges) obj)._OnDefaultRoute) && object.Equals((object) this._Name, (object) ((PathChanges) obj)._Name))) && (object.Equals((object) this._ObjectToChange, (object) ((PathChanges) obj)._ObjectToChange) && object.Equals((object) this._Notes, (object) ((PathChanges) obj)._Notes) && object.Equals((object) this._Description, (object) ((PathChanges) obj)._Description)) && base.Equals(obj);
    }

    public NamedSubentityRef ReturnToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReturnToStep));
      }
    }

    public NamedSubentityRef FromStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FromStep));
      }
    }

    public TxnDetailsChanges TxnDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDetails), (object) value);
      }
      get
      {
        return (TxnDetailsChanges) this.PropertyGet(nameof (TxnDetails));
      }
    }

    public NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }

    public Primitive<bool> IsDefaultPath
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDefaultPath), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsDefaultPath));
      }
    }

    public Primitive<bool> OnDefaultRoute
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnDefaultRoute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OnDefaultRoute));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
