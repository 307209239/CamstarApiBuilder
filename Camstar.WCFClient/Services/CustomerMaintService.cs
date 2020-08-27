// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CustomerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CustomerMaintService : NamedDataObjectMaintBase
  {
    public CustomerMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICustomerMaintService), userProfile);
    }

    public ResultStatus Delete(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).Delete(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus Delete(CustomerMaint customerMaint)
    {
      return this.Delete(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus Delete(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.Delete(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).Freeze(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus Freeze(CustomerMaint customerMaint)
    {
      return this.Freeze(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus Freeze(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.Freeze(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).GetWIPMsgs(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CustomerMaint customerMaint)
    {
      return this.GetWIPMsgs(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.GetWIPMsgs(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).Load(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus Load(CustomerMaint customerMaint)
    {
      return this.Load(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus Load(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.Load(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CustomerMaint customerMaint,
      CustomerMaint_LoadESigDetails_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).LoadESigDetails(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.LoadESigDetails, (CustomerMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CustomerMaint) null, (CustomerMaint_LoadESigDetails_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(CustomerMaint customerMaint)
    {
      return this.LoadESigDetails(customerMaint, (CustomerMaint_LoadESigDetails_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.LoadESigDetails(customerMaint, (CustomerMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).New(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus New(CustomerMaint customerMaint)
    {
      return this.New(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus New(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.New(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).NewCopy(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus NewCopy(CustomerMaint customerMaint)
    {
      return this.NewCopy(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus NewCopy(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.NewCopy(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).SaveAs(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus SaveAs(CustomerMaint customerMaint)
    {
      return this.SaveAs(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus SaveAs(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.SaveAs(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) customerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).UnFreeze(this._UserProfile, customerMaint, parameters, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(customerMaint, CustomerMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) customerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CustomerMaint) null, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus UnFreeze(CustomerMaint customerMaint)
    {
      return this.UnFreeze(customerMaint, (CustomerMaint_Parameters) null, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.UnFreeze(customerMaint, (CustomerMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CustomerMaint) customerMaint, (CustomerMaint_LoadESigDetails_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.New((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.Load((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject customerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CustomerMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CustomerMaint) customerMaint, (CustomerMaint_Parameters) parameters, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      try
      {
        CustomerMaintMethod[] methods = new CustomerMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICustomerMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CustomerMaint cdo,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      try
      {
        return ((ICustomerMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CustomerMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CustomerMaint) cdo, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.GetEnvironment((CustomerMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CustomerMaint cdo,
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      result = (CustomerMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICustomerMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CustomerMaintMethod(cdo, CustomerMaintMethods.ExecuteTransaction, (CustomerMaint_Parameters) null));
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
        CustomerMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CustomerMaint) cdo, (CustomerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CustomerMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CustomerMaint_Request) null, out CustomerMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CustomerMaint_Request request,
      out CustomerMaint_Result result)
    {
      return this.ExecuteTransaction((CustomerMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CustomerMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CustomerMaintMethod(cdo, CustomerMaintMethods.AddDataTransaction, (CustomerMaint_Parameters) null));
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
        return this.AddDataTransaction((CustomerMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
