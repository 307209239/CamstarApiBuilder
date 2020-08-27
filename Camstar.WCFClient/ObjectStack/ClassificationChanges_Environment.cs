// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ClassificationChanges_Environment
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
  public class ClassificationChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ClassificationChanges_Environment_EventClassification")]
    [Metadata("EventClassification", "ClassificationEnum", false, false, false, "Integer", 1052513, false, false, true, null)]
    protected Environment _EventClassification;
    [DataMember(EmitDefaultValue = false, Name = "ClassificationChanges_Environment_ObjectToChange")]
    [Metadata("Used to classify QualityObjects", "Classification", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ClassificationChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052512, false, false, false, null)]
    protected new Environment _Name;

    public Environment EventClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventClassification));
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
