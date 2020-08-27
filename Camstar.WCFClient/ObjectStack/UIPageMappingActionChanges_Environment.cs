// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageMappingActionChanges_Environment
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
  public class UIPageMappingActionChanges_Environment : UIRedirectActionChanges_Environment
  {
    [Metadata("UI PageMapping Redirect Action", "UIPageMappingAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Environment_ListItemToChange")]
    [Metadata("UI PageMapping Redirect Action", "UIPageMappingActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Environment_MapItem")]
    [Metadata("Generic String", "", false, false, false, "String", 1052803, false, false, false, null)]
    protected Environment _MapItem;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052785, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Environment_Name")]
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

    public Environment MapItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MapItem));
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
