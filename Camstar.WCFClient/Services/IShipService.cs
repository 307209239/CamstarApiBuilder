// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IShipService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IShipService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Ship ship,
      Ship_LoadESigDetails_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ShipMethod[] methods,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Ship ship,
      Ship_Request request,
      out Ship_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Ship ship,
      Ship_Request request,
      out Ship_Result result);
  }
}
