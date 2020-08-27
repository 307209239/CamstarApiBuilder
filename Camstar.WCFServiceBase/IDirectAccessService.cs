// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.IDirectAccessService
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.ServiceModel;

namespace Camstar.WCF.Service
{
  [ServiceContract]
  public interface IDirectAccessService
  {
    [OperationContract]
    ResultStatus Submit(UserProfile userProfile, string inputXml, out string outputXml);
  }
}
