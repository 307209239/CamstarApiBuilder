// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UILinkActionChanges_Environment
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
  public class UILinkActionChanges_Environment : UIActionChanges_Environment
  {
    [Metadata("URL", "", false, false, false, "String", 1049620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Environment_URL")]
    protected Environment _URL;
    [Metadata("UI Link Action", "UILinkAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Environment_ListItemToChange")]
    [Metadata("UI Link Action", "UILinkActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Query String Parameter", "QueryStringParameterChanges", false, false, false, "QueryStringParameterChanges", 1052819, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Environment_QueryStringParameters")]
    protected QueryStringParameterChanges_Environment _QueryStringParameters;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052779, false, false, false, null)]
    protected new Environment _Name;

    public Environment URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (URL));
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

    public QueryStringParameterChanges_Environment QueryStringParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryStringParameters), (object) value);
      }
      get
      {
        return (QueryStringParameterChanges_Environment) this.PropertyGet(nameof (QueryStringParameters));
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
