// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowActivityChanges_Environment
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
  public class UIPageFlowActivityChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("LongString", "", false, false, false, "String", 1051505, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_Environment_Content")]
    protected Environment _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_Environment_ObjectToChange")]
    [Metadata("UI PageFlow Activity", "UIPageFlowActivity", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("UI PageFlow Activity", "UIPageFlowActivityChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_Environment_Name")]
    [Metadata("UI Provider Component Name which is typically a generated GUID", "", false, true, false, "String", 1051508, false, false, false, null)]
    protected new Environment _Name;

    public Environment Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Content));
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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
