// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IShopFloorBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public interface IShopFloorBase : IUpdateBase
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      DCObject shopFloor,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus CreateParametricData(DCObject shopFloor);

    [OperationContract]
    ResultStatus CreateParametricData();

    [OperationContract]
    ResultStatus GetActions(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetActions(DCObject shopFloor, Request request, out Result result);

    [OperationContract]
    ResultStatus GetActions(DCObject shopFloor);

    [OperationContract]
    ResultStatus GetActions();

    [OperationContract]
    ResultStatus GetDataPoints(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetDataPoints(DCObject shopFloor, Request request, out Result result);

    [OperationContract]
    ResultStatus GetDataPoints(DCObject shopFloor);

    [OperationContract]
    ResultStatus GetDataPoints();

    [OperationContract]
    ResultStatus LoadESigDetails(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      DCObject shopFloor,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(DCObject shopFloor);

    [OperationContract]
    ResultStatus LoadESigDetails();

    [OperationContract]
    ResultStatus ProcessComputation(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      DCObject shopFloor,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus ProcessComputation(DCObject shopFloor);

    [OperationContract]
    ResultStatus ProcessComputation();

    [OperationContract]
    ResultStatus ResolveParametricData(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      DCObject shopFloor,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(DCObject shopFloor);

    [OperationContract]
    ResultStatus ResolveParametricData();
  }
}
