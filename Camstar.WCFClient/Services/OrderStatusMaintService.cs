// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OrderStatusMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OrderStatusMaintService : UserCodeMaintBase
  {
    public OrderStatusMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOrderStatusMaintService), userProfile);
    }

    public ResultStatus Delete(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).Delete(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus Delete(OrderStatusMaint orderStatusMaint)
    {
      return this.Delete(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus Delete(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.Delete(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).Freeze(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus Freeze(OrderStatusMaint orderStatusMaint)
    {
      return this.Freeze(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus Freeze(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.Freeze(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).GetWIPMsgs(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(OrderStatusMaint orderStatusMaint)
    {
      return this.GetWIPMsgs(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.GetWIPMsgs(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).Load(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus Load(OrderStatusMaint orderStatusMaint)
    {
      return this.Load(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus Load(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.Load(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_LoadESigDetails_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).LoadESigDetails(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.LoadESigDetails, (OrderStatusMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OrderStatusMaint) null, (OrderStatusMaint_LoadESigDetails_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus LoadESigDetails(OrderStatusMaint orderStatusMaint)
    {
      return this.LoadESigDetails(orderStatusMaint, (OrderStatusMaint_LoadESigDetails_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.LoadESigDetails(orderStatusMaint, (OrderStatusMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).New(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus New(OrderStatusMaint orderStatusMaint)
    {
      return this.New(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus New(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.New(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).NewCopy(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus NewCopy(OrderStatusMaint orderStatusMaint)
    {
      return this.NewCopy(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus NewCopy(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.NewCopy(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).SaveAs(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus SaveAs(OrderStatusMaint orderStatusMaint)
    {
      return this.SaveAs(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus SaveAs(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.SaveAs(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Parameters parameters,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).UnFreeze(this._UserProfile, orderStatusMaint, parameters, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(orderStatusMaint, OrderStatusMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) orderStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((OrderStatusMaint) null, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus UnFreeze(OrderStatusMaint orderStatusMaint)
    {
      return this.UnFreeze(orderStatusMaint, (OrderStatusMaint_Parameters) null, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus UnFreeze(
      OrderStatusMaint orderStatusMaint,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.UnFreeze(orderStatusMaint, (OrderStatusMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.Delete((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_LoadESigDetails_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.New((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.Load((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject orderStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OrderStatusMaint) orderStatusMaint, (OrderStatusMaint_Parameters) parameters, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      try
      {
        OrderStatusMaintMethod[] methods = new OrderStatusMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOrderStatusMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OrderStatusMaint cdo,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      try
      {
        return ((IOrderStatusMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((OrderStatusMaint) cdo, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.GetEnvironment((OrderStatusMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OrderStatusMaint cdo,
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      result = (OrderStatusMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderStatusMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OrderStatusMaintMethod(cdo, OrderStatusMaintMethods.ExecuteTransaction, (OrderStatusMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderStatusMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OrderStatusMaint) cdo, (OrderStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OrderStatusMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (OrderStatusMaint_Request) null, out OrderStatusMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OrderStatusMaint_Request request,
      out OrderStatusMaint_Result result)
    {
      return this.ExecuteTransaction((OrderStatusMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OrderStatusMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OrderStatusMaintMethod(cdo, OrderStatusMaintMethods.AddDataTransaction, (OrderStatusMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((OrderStatusMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
