// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuItemChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PortalMenuSubMenuChanges_Environment))]
  [KnownType(typeof (PortalMenuCommandChanges_Environment))]
  [Serializable]
  public class PortalMenuItemChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_LabelName")]
    [Metadata("LabelName", "", false, false, false, "String", 1052772, false, false, false, null)]
    protected Environment _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_Caption")]
    [Metadata("Caption", "", false, true, false, "String", 1049386, false, false, false, null)]
    protected Environment _Caption;
    [Metadata("An instance of a PortalMenuItem is used to define an entry within a PortalMenuDefinition. Each PortalMenuItem defines either a command to execute or a reference to another PortalMenuDefinition.", "PortalMenuItemChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Tab defs for use in menus.", "PortalTab", false, false, false, "NamedObjectRef", 1052686, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_PortalTab")]
    protected Environment _PortalTab;
    [Metadata("An instance of a PortalMenuItem is used to define an entry within a PortalMenuDefinition. Each PortalMenuItem defines either a command to execute or a reference to another PortalMenuDefinition.", "PortalMenuItem", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_PortalTabOption")]
    [Metadata("Determines the TabOption when a new page is opened.", "PortalTabOptionEnum", false, false, false, "Integer", 1052707, false, false, true, null)]
    protected Environment _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_Sequence")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuItemChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public Environment Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Caption));
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

    public Environment PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalTab));
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

    public Environment PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalTabOption));
      }
    }

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

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
