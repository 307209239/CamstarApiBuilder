// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WCFService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public abstract class WCFService : WCFServiceBase, IWCFService
  {
    public event WCFService.MethodCallHandler BeforeMethodCall;

    public event WCFService.MethodCallHandler AfterMethodCall;

    public ResultStatus BeginTransaction()
    {
      ResultStatus resultStatus = new ResultStatus();
      if (this._IsTransactionOpened)
      {
        resultStatus.IsSuccess = false;
        resultStatus.ExceptionData = new ExceptionDataType();
        resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
        resultStatus.ExceptionData.Description = "Transaction is already began.";
      }
      else
      {
        this._IsTransactionOpened = true;
        this._Methods.Clear();
        resultStatus.IsSuccess = true;
        resultStatus.Message = "Transaction begining successful.";
      }
      return resultStatus;
    }

    public ResultStatus RollBackTransaction()
    {
      ResultStatus resultStatus = new ResultStatus();
      if (this._IsTransactionOpened)
      {
        this._IsTransactionOpened = false;
        this._Methods.Clear();
        resultStatus.IsSuccess = true;
        resultStatus.Message = "Transaction canceling successful.";
      }
      else
      {
        resultStatus.IsSuccess = false;
        resultStatus.ExceptionData = new ExceptionDataType();
        resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
        resultStatus.ExceptionData.Description = "Transaction was not began.";
      }
      return resultStatus;
    }

    public ResultStatus CommitTransaction()
    {
      return this.OnCommitTransaction((Request) null, out Result _);
    }

    protected virtual ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      ResultStatus resultStatus = new ResultStatus()
      {
        IsSuccess = false,
        ExceptionData = new ExceptionDataType()
      };
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      resultStatus.ExceptionData.Description = "There is no CommitTransaction method";
      return resultStatus;
    }

    protected virtual ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      ResultStatus resultStatus = new ResultStatus()
      {
        IsSuccess = false,
        ExceptionData = new ExceptionDataType()
      };
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      resultStatus.ExceptionData.Description = "There is no GetEnvironment method";
      return resultStatus;
    }

    public ResultStatus ExecuteTransaction()
    {
      return this.OnExecuteTransaction((DCObject) null, (Request) null, out Result _);
    }

    protected virtual ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      ResultStatus resultStatus = new ResultStatus()
      {
        IsSuccess = false,
        ExceptionData = new ExceptionDataType()
      };
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      resultStatus.ExceptionData.Description = "There is no ExecuteTransaction method";
      return resultStatus;
    }

    protected virtual ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      ResultStatus resultStatus = new ResultStatus()
      {
        IsSuccess = false,
        ExceptionData = new ExceptionDataType()
      };
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      resultStatus.ExceptionData.Description = "There is no AddDataTransaction method";
      return resultStatus;
    }

    protected ResultStatus GetAddDataTransactionException()
    {
      ResultStatus resultStatus = new ResultStatus()
      {
        IsSuccess = false,
        ExceptionData = new ExceptionDataType()
      };
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      resultStatus.ExceptionData.Description = "Transaction was not began.";
      return resultStatus;
    }

    protected ResultStatus NoMethod(string methodName)
    {
      ResultStatus resultStatus = new ResultStatus()
      {
        IsSuccess = false,
        ExceptionData = new ExceptionDataType()
      };
      resultStatus.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      resultStatus.ExceptionData.Description = this.GetType().Name + "." + methodName + " method not found.";
      return resultStatus;
    }

    protected virtual void OnBeforeCall(
      string methodName,
      DCObject cdo,
      Parameters parameters,
      Request request)
    {
      if (this.BeforeMethodCall == null)
        return;
      this.BeforeMethodCall((object) this, new WCFServiceEventArgs(this._UserProfile, methodName, cdo, parameters, request, (Result) null));
    }

    protected virtual void OnAfterCall(
      string methodName,
      ResultStatus res,
      DCObject cdo,
      Parameters parameters,
      Request request,
      Result result)
    {
      if (this.AfterMethodCall == null)
        return;
      this.AfterMethodCall((object) this, new WCFServiceEventArgs(this._UserProfile, methodName, cdo, parameters, request, result, res));
    }

    protected ResultStatus AddMethod(Method method)
    {
      ResultStatus resultStatus = new ResultStatus();
      this._Methods.Add(method);
      resultStatus.IsSuccess = true;
      resultStatus.Message = "Method addition successful";
      return resultStatus;
    }

    protected int GetMethodCount()
    {
      if (!this._IsTransactionOpened)
        throw new WCFServiceException("Transaction is not opened.");
      if (this._Methods.Count == 0)
        throw new WCFServiceException("No method found.");
      return this._Methods.Count;
    }

    protected void CopyMethods(Method[] dest)
    {
      this._Methods.CopyTo(dest);
      this._Methods.Clear();
      this._IsTransactionOpened = false;
    }

    ResultStatus IWCFService.BeginTransaction()
    {
      return this.BeginTransaction();
    }

    ResultStatus IWCFService.RollBackTransaction()
    {
      return this.RollBackTransaction();
    }

    ResultStatus IWCFService.CommitTransaction()
    {
      return this.OnCommitTransaction((Request) null, out Result _);
    }

    ResultStatus IWCFService.CommitTransaction(
      Request request,
      out Result result)
    {
      return this.OnCommitTransaction(request, out result);
    }

    ResultStatus IWCFService.GetEnvironment(
      Request request,
      out Result result)
    {
      return this.OnGetEnvironment((DCObject) null, request, out result);
    }

    ResultStatus IWCFService.GetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      return this.OnGetEnvironment(cdo, request, out result);
    }

    ResultStatus IWCFService.ExecuteTransaction()
    {
      return this.OnExecuteTransaction((DCObject) null, (Request) null, out Result _);
    }

    ResultStatus IWCFService.ExecuteTransaction(
      Request request,
      out Result result)
    {
      return this.OnExecuteTransaction((DCObject) null, request, out result);
    }

    ResultStatus IWCFService.ExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      return this.OnExecuteTransaction(cdo, request, out result);
    }

    ResultStatus IWCFService.ExecuteTransaction(DCObject cdo)
    {
      return this.OnExecuteTransaction(cdo, (Request) null, out Result _);
    }

    ResultStatus IWCFService.AddDataTransaction(DCObject cdo)
    {
      return this.OnAddDataTransaction(cdo);
    }

    public delegate void MethodCallHandler(object sender, WCFServiceEventArgs args);
  }
}
