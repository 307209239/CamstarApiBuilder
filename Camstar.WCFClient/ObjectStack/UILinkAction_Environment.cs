// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UILinkAction_Environment
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
  public class UILinkAction_Environment : UIAction_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_Environment_URL")]
    [Metadata("URL", "", false, false, true, "String", 1049620, false, false, false, null)]
    protected Environment _URL;
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_Environment_QueryStringParameters")]
    [Metadata("Query String Parameter", "QueryStringParameter", false, false, false, "QueryStringParameter", 1052819, false, false, false, null)]
    protected QueryStringParameter_Environment _QueryStringParameters;
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052779, false, false, false, null)]
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

    public QueryStringParameter_Environment QueryStringParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryStringParameters), (object) value);
      }
      get
      {
        return (QueryStringParameter_Environment) this.PropertyGet(nameof (QueryStringParameters));
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
