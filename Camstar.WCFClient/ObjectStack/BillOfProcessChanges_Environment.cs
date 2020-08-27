// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessChanges_Environment
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
  public class BillOfProcessChanges_Environment : RevisionedObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Environment_Base")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcessBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Environment_ObjectToChange")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Changes CDO for Bill Of Process Override", "BillOfProcessOverrideChanges", false, true, false, "BillOfProcessOverrideChanges", 1050938, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Environment_BillOfProcessOverrides")]
    protected BillOfProcessOverrideChanges_Environment _BillOfProcessOverrides;
    [Metadata("Revision (unique within the context of the base entity)", "", false, true, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Environment_Revision")]
    protected new Environment _Revision;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050931, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public new Environment ObjectToChange
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

    public BillOfProcessOverrideChanges_Environment BillOfProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcessOverrides), (object) value);
      }
      get
      {
        return (BillOfProcessOverrideChanges_Environment) this.PropertyGet(nameof (BillOfProcessOverrides));
      }
    }

    public new Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
