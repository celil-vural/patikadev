package org.example;

public class InvalidAuthenticationException extends Exception{
    public String message;

    public InvalidAuthenticationException(String message) {
        super(message);
        this.message = message;
    }
    @Override
    public String toString() {
        return "InvalidAuthenticationException{" +
                "message='" + message + '\'' +
                '}';
    }
}
