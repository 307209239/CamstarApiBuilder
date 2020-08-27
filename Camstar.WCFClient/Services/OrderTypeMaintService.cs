// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OrderTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OrderTypeMaintService : UserCodeMaintBase
  {
    public OrderTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOrderTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).Delete(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus Delete(OrderTypeMaint orderTypeMaint)
    {
      return this.Delete(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus Delete(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.Delete(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).Freeze(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus Freeze(OrderTypeMaint orderTypeMaint)
    {
      return this.Freeze(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.Freeze(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(OrderTypeMaint orderTypeMaint)
    {
      return this.GetWIPMsgs(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.GetWIPMsgs(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).Load(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus Load(OrderTypeMaint orderTypeMaint)
    {
      return this.Load(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus Load(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.Load(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_LoadESigDetails_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.LoadESigDetails, (OrderTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OrderTypeMaint) null, (OrderTypeMaint_LoadESigDetails_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(OrderTypeMaint orderTypeMaint)
    {
      return this.LoadESigDetails(orderTypeMaint, (OrderTypeMaint_LoadESigDetails_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.LoadESigDetails(orderTypeMaint, (OrderTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).New(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus New(OrderTypeMaint orderTypeMaint)
    {
      return this.New(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus New(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.New(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).NewCopy(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus NewCopy(OrderTypeMaint orderTypeMaint)
    {
      return this.NewCopy(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.NewCopy(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).SaveAs(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus SaveAs(OrderTypeMaint orderTypeMaint)
    {
      return this.SaveAs(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.SaveAs(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).UnFreeze(this._UserProfile, orderTypeMaint, parameters, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(orderTypeMaint, OrderTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) orderTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((OrderTypeMaint) null, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(OrderTypeMaint orderTypeMaint)
    {
      return this.UnFreeze(orderTypeMaint, (OrderTypeMaint_Parameters) null, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.UnFreeze(orderTypeMaint, (OrderTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_LoadESigDetails_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject orderTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OrderTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OrderTypeMaint) orderTypeMaint, (OrderTypeMaint_Parameters) parameters, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      try
      {
        OrderTypeMaintMethod[] methods = new OrderTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOrderTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OrderTypeMaint cdo,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      try
      {
        return ((IOrderTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OrderTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((OrderTypeMaint) cdo, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.GetEnvironment((OrderTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OrderTypeMaint cdo,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      result = (OrderTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOrderTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OrderTypeMaintMethod(cdo, OrderTypeMaintMethods.ExecuteTransaction, (OrderTypeMaint_Parameters) null));
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
        OrderTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OrderTypeMaint) cdo, (OrderTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OrderTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (OrderTypeMaint_Request) null, out OrderTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result)
    {
      return this.ExecuteTransaction((OrderTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OrderTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OrderTypeMaintMethod(cdo, OrderTypeMaintMethods.AddDataTransaction, (OrderTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((OrderTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
