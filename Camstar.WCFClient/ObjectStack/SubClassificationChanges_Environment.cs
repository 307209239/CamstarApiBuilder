// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubClassificationChanges_Environment
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
  public class SubClassificationChanges_Environment : UserCodeChanges_Environment
  {
    [Metadata("EventSubClassification", "SubClassificationEnum", false, false, false, "Integer", 1052514, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_Environment_EventSubClassification")]
    protected Environment _EventSubClassification;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubClassificationChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052560, false, false, false, null)]
    protected new Environment _Name;

    public Environment EventSubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventSubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventSubClassification));
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
