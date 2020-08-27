// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetupChanges
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
  public class SetupChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_StdSetupLaborTime")]
    protected Primitive<double> _StdSetupLaborTime;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_StdSetupTime")]
    protected Primitive<double> _StdSetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Base")]
    protected new RevisionedObjectRef _Base;

    public override bool Equals(object obj)
    {
      return obj is SetupChanges && object.Equals((object) this._ResourceGroup, (object) ((SetupChanges) obj)._ResourceGroup) && (object.Equals((object) this._StdSetupLaborTime, (object) ((SetupChanges) obj)._StdSetupLaborTime) && object.Equals((object) this._StdSetupTime, (object) ((SetupChanges) obj)._StdSetupTime)) && (object.Equals((object) this._Name, (object) ((SetupChanges) obj)._Name) && object.Equals((object) this._DocumentSet, (object) ((SetupChanges) obj)._DocumentSet) && (object.Equals((object) this._ObjectToChange, (object) ((SetupChanges) obj)._ObjectToChange) && object.Equals((object) this._Base, (object) ((SetupChanges) obj)._Base))) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Primitive<double> StdSetupLaborTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdSetupLaborTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdSetupLaborTime));
      }
    }

    public Primitive<double> StdSetupTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdSetupTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (StdSetupTime));
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

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }
  }
}
