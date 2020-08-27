// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionCategoryChanges_Environment
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
  public class ActionCategoryChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_Environment_LabelText")]
    [Metadata("Label Value.", "", false, false, false, "String", 1049993, false, false, false, null)]
    protected Environment _LabelText;
    [Metadata("LabelName", "", false, false, false, "String", 1052772, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_Environment_LabelName")]
    protected Environment _LabelName;
    [Metadata("ActionCategory object is using to collect Actions in categories on SourcePages", "ActionCategory", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053019, false, false, false, null)]
    protected new Environment _Name;

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelText));
      }
    }

    public Environment LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelName));
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
