// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetMfgDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetMfgDataService
  {
    [OperationContract]
    ResultStatus GetData(
      UserProfile userProfile,
      GetMfgData getMfgData,
      GetMfgData_Parameters parameters,
      GetMfgData_Request request,
      out GetMfgData_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GetMfgData getMfgData,
      GetMfgData_Parameters parameters,
      GetMfgData_Request request,
      out GetMfgData_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetMfgDataMethod[] methods,
      GetMfgData_Request request,
      out GetMfgData_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GetMfgData getMfgData,
      GetMfgData_Request request,
      out GetMfgData_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GetMfgData getMfgData,
      GetMfgData_Request request,
      out GetMfgData_Result result);
  }
}
