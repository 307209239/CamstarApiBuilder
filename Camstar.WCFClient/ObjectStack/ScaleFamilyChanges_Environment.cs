﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ScaleFamilyChanges_Environment
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
  public class ScaleFamilyChanges_Environment : ResourceFamilyChanges_Environment
  {
    [Metadata("Scale Family is used to differentiate between types of Scales", "ScaleFamily", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052141, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ScaleFamilyChanges_Environment_Name")]
    protected new Environment _Name;

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
