// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public interface IUpdateBase : IServiceBase
  {
    [OperationContract]
    ResultStatus Load(
      DCObject update,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus Load(DCObject update, Request request, out Result result);

    [OperationContract]
    ResultStatus Load(DCObject update);

    [OperationContract]
    ResultStatus Load();
  }
}
