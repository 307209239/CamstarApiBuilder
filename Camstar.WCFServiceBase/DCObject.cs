// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.DCObject
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public abstract class DCObject
  {
    [DataMember(EmitDefaultValue = false)]
    public Action? FieldAction;
    [DataMember(EmitDefaultValue = false)]
    public bool? IgnoreTypeDifference;
    [DataMember(EmitDefaultValue = false)]
    public Camstar.WCF.Service.ListItemAction? ListItemAction;
    [DataMember(EmitDefaultValue = false)]
    public int? ListItemIndex;
    [DataMember(EmitDefaultValue = false)]
    public NamedObjectRef Key;
    [DataMember(EmitDefaultValue = false)]
    public string CDOTypeName;
  }
}
