// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetMfgLotsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetMfgLotsService
  {
    [OperationContract]
    ResultStatus GetData(
      UserProfile userProfile,
      GetMfgLots getMfgLots,
      GetMfgLots_Parameters parameters,
      GetMfgLots_Request request,
      out GetMfgLots_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GetMfgLots getMfgLots,
      GetMfgLots_Parameters parameters,
      GetMfgLots_Request request,
      out GetMfgLots_Result result);

    [OperationContract]
    ResultStatus RetrieveContainers(
      UserProfile userProfile,
      GetMfgLots getMfgLots,
      GetMfgLots_Parameters parameters,
      GetMfgLots_Request request,
      out GetMfgLots_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetMfgLotsMethod[] methods,
      GetMfgLots_Request request,
      out GetMfgLots_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GetMfgLots getMfgLots,
      GetMfgLots_Request request,
      out GetMfgLots_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GetMfgLots getMfgLots,
      GetMfgLots_Request request,
      out GetMfgLots_Result result);
  }
}
